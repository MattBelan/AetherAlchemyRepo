using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BounceScript : MonoBehaviour {

    GameObject bouncePotion;
    Collider bounceCollider;
    Collider potCollider;
    public GameObject bounceEffect;

    // Use this for initialization
    void Start()
    {
        bounceCollider = GetComponent<Collider>();
    }

    // Update is called once per frame
    void Update()
    {
        bounceCollider = gameObject.GetComponent<Collider>();
        bouncePotion = GameObject.Find("bouncePotion(Clone)");
        if (bouncePotion != null)
        {
            potCollider = bouncePotion.GetComponent<Collider>();
        }
        if (CheckIntersection())
        {
            GameObject.Find("RigidBodyFPSController").GetComponent<PlayerScript>().potList.Remove(bouncePotion);
            if (GameObject.Find("bounceTest(Clone)") == null)
            {
                Instantiate(bounceEffect, bouncePotion.transform.position+bouncePotion.transform.up/10, bouncePotion.transform.rotation);
            }
            GameObject.Find("bounceTest(Clone)").transform.position = bouncePotion.transform.position;
            Destroy(bouncePotion);
        }
    }

    bool CheckIntersection()
    {
        if (bouncePotion == null)
        {
            return false;
        }
        if (bounceCollider.bounds.Intersects(potCollider.bounds))
        {
            return true;
        }
        return false;
    }
}
