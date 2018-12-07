using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BounceEffect : MonoBehaviour {
    
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        
	}

    /// <summary>
    /// Reverses the y velocity of specified objects
    /// </summary>
    /// <param name="other"></param>
	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.tag == "Movable"||other.gameObject.tag == "Rotating") {
			Rigidbody otherRigid = other.attachedRigidbody;
			if (otherRigid.velocity.y < -3) {
				if(other.gameObject.tag == "Rotating"){
                    Vector3 newVelocity = otherRigid.angularVelocity;
                    newVelocity = -newVelocity;
                    otherRigid.angularVelocity = newVelocity;
				}
                else
                {
                    Vector3 newVelocity = otherRigid.velocity;
                    newVelocity.y = -newVelocity.y;
                    otherRigid.velocity = newVelocity;
                }
			}
		}
	}
}
