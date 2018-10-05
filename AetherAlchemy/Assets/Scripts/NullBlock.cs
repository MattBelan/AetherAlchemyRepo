using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NullBlock : MonoBehaviour {

    GameObject burnablePotion;
    Collider nullCollider;
    Collider potCollider;

    // Use this for initialization
    void Start()
    {
        nullCollider = GetComponentInChildren<Collider>();
    }

    // Update is called once per frame
    void Update()
    {
        nullCollider = gameObject.GetComponentInChildren<Collider>();
        burnablePotion = GameObject.Find("PotionTest(Clone)");
        if (burnablePotion != null)
        {
            potCollider = burnablePotion.GetComponent<Collider>();
        }
        /*
        if (CheckIntersection())
        {
            GameObject.Find("RigidBodyFPSController").GetComponent<PlayerScript>().potList.Remove(burnablePotion);
            Destroy(burnablePotion);
        }
        */
    }

    bool CheckIntersection()
    {
        if (burnablePotion == null)
        {
            return false;
        }
        if (nullCollider.bounds.Intersects(potCollider.bounds))
        {
            return true;
        }
        return false;
    }

    void OnCollisionEnter(Collision pot)
    {
        if(burnablePotion == pot.gameObject)
        {
            GameObject.Find("ShatterSound").GetComponent<AudioSource>().Play();
            GameObject.Find("RigidBodyFPSController").GetComponent<PlayerScript>().potList.Remove(burnablePotion);
            Destroy(burnablePotion);
        }
    }
}
