using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PotBehavior : MonoBehaviour {

	//potion variables
	public Vector3 potPos;
	public Vector3 direction;
	public Vector3 velocity;
	public Vector3 acceleration;
    public string type;

	public float speed;
	//
	public Vector3 gravity;

	// Use this for initialization
	void Start () {
		potPos = transform.position;
		potPos.y -= .35f;
		direction = GameObject.Find ("MainCamera").transform.forward;
		direction.Normalize ();
		velocity = speed * direction;
	}
	
	// Update is called once per frame
	void Update () {

        potPos = transform.position;
        ApplyGravity ();


		velocity += acceleration * Time.deltaTime;

		potPos += velocity * Time.deltaTime;

		direction = velocity.normalized;

		acceleration = Vector3.zero;
		transform.position = potPos;

        if (transform.position.y < -40)
        {
            GameObject.Find("RigidBodyFPSController").GetComponent<PlayerScript>().potList.Remove(gameObject);
            Destroy(gameObject);
        }
	}

    /// <summary>
    /// Applys gravity to the potion
    /// </summary>
	void ApplyGravity(){
		acceleration += gravity;
	
	}
}
