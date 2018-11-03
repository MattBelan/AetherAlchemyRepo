using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class doorInput : MonoBehaviour {
    private Animator animator;

	// Use this for initialization
	void Start () {
        animator = GetComponent<Animator>();
    }
	
	// Update is called once per frame
	void Update () {
        if(animator.GetCurrentAnimatorStateInfo(0).IsName("Open") && animator.GetCurrentAnimatorStateInfo(0).normalizedTime >= 1)
            GetComponent<BoxCollider>().enabled = false;
    }


    void OnCollisionEnter(Collision c)
    {
        if (!animator.GetCurrentAnimatorStateInfo(0).IsName("Open") && c.collider.name == "RigidBodyFPSController")
            GetComponent<Animator>().Play("Open"); //Should play the animation
    }
}