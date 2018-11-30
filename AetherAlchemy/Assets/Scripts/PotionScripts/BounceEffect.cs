using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BounceEffect : MonoBehaviour {

	// Use this for initialization
	void Start () {
        transform.rotation = new Quaternion(0, 0, 0, 0);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.tag == "Movable"||other.gameObject.tag == "Rotating") {
			Rigidbody otherRigid = other.attachedRigidbody;
			if (otherRigid.velocity.y < -3) {
				Vector3 newVelocity = otherRigid.velocity;
				newVelocity.y = -newVelocity.y;
				if(other.gameObject.tag == "Rotating"){
					newVelocity.x = -newVelocity.x;
					newVelocity.z = -newVelocity.z;
				}

				otherRigid.velocity = newVelocity;
			}
		}
	}
}
