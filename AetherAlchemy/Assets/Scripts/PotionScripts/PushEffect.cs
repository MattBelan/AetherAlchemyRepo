using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PushEffect : MonoBehaviour {

    float timer;
    [SerializeField] float pushScalar;
    [SerializeField] float radius = 1;

    // Use this for initialization
    void Start () {
        SphereCollider coll = GetComponent<SphereCollider>();
        coll.radius = radius;
        timer = 1.0f;
	}
	
	// Update is called once per frame
	void Update () {
        timer -= Time.deltaTime;
        if (timer <= 0)
        {
            Destroy(gameObject);
        }
    }

    /// <summary>
    /// Forces certain objects away from the center of the area
    /// </summary>
    /// <param name="other"></param>
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Movable" || other.gameObject.tag == "Player")
        {
            Vector3 pushForce = other.gameObject.transform.position - transform.position;
            float distance = pushForce.magnitude;
            pushForce = pushForce.normalized;
            pushForce *= (pushScalar * (distance / radius));

			if (other.gameObject.tag == "Player") {
				other.gameObject.GetComponent<Rigidbody>().velocity = pushForce;
			} 
			else 
			{
				other.gameObject.GetComponent<Rigidbody>().velocity = pushForce;
			}
        }
    }
}
