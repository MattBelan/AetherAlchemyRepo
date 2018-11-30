using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PushScript : MonoBehaviour {

    public GameObject pushArea;
    GameObject player;
    PlayerScript ps;
    float timer;
    [SerializeField] float pushScalar;
    [SerializeField] float radius = 1;

    bool pushing = false;

    // Use this for initialization
    void Start () {
        player = GameObject.FindWithTag("Player");
        ps = player.GetComponent<PlayerScript>();
    }
	
	// Update is called once per frame
	void Update () {
        if (pushing)
        {
            timer -= Time.deltaTime;
            if (timer <= 0)
            {
                ps.potList.Remove(gameObject);
                Destroy(gameObject);
            }
        }
	}

    void OnCollisionEnter(Collision other)
    {
        if (pushing)
        {
            if (other.gameObject.tag == "Movable" || other.gameObject.tag == "Player")
            {
                Vector3 pushForce = other.gameObject.transform.position - transform.position;
                float distance = pushForce.magnitude;
                pushForce = pushForce.normalized;
                pushForce *= (pushScalar * (distance / radius));

                if (other.gameObject.tag == "Player")
                {
                    other.gameObject.GetComponent<Rigidbody>().velocity = pushForce;
                }
                else
                {
                    other.gameObject.GetComponent<Rigidbody>().velocity = pushForce;
                }
            }
        }
        else
        {
            if (other.gameObject.tag != "Player")
            {
                if (other.gameObject.tag != "Nullifier")
                {
                    pushing = true;
                    SphereCollider coll = GetComponent<SphereCollider>();
                    coll.radius = radius;
                    timer = 1.0f;
                }
            }
        }
    }
}
