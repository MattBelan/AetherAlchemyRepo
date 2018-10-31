using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PushEffect : MonoBehaviour {

    float timer;
    public float pushScalar;
	// Use this for initialization
	void Start () {
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

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Movable" || other.gameObject.tag == "Player")
        {
            Vector3 pushForce = new Vector3();

            pushForce.x = other.gameObject.transform.position.x - transform.position.x;
            pushForce.y = other.gameObject.transform.position.y - transform.position.y;
            pushForce.z = other.gameObject.transform.position.z - transform.position.z;

            float magnitude = Vector3.Magnitude(pushForce);

            pushForce.Normalize();
            pushForce = pushForce * pushScalar / magnitude;
            
            other.gameObject.GetComponent<Rigidbody>().AddForce(pushForce, ForceMode.Impulse);
        }
    }
}
