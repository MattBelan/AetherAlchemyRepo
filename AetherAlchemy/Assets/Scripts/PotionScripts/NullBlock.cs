using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NullBlock : MonoBehaviour {

    GameObject burnablePotion;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        burnablePotion = GameObject.Find("PotionTest(Clone)");
    }

    /// <summary>
    /// On Collision with Fire potion, destroy fire potion
    /// </summary>
    /// <param name="pot"></param>
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
