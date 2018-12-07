using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BurnableScript : MonoBehaviour {

    GameObject burnablePotion;
    Collider burnCollider;
    Collider potCollider;
    GameObject player;

    AudioSource burn;
    ParticleSystem fire;

	// Use this for initialization
	void Start () {
        burnCollider = GetComponentInChildren<Collider>();
        burn = GetComponent<AudioSource>();
	}

	// Update is called once per frame
	void Update () {
        player = GameObject.Find("RigidBodyFPSController");
        burnCollider = gameObject.GetComponentInChildren<Collider>();
        burnablePotion = GameObject.Find("PotionTest(Clone)");
        if (burnablePotion != null)
        {
            potCollider = burnablePotion.GetComponent<Collider>();
        }
	}

    /// <summary>
    /// On collision, burn away burnable objects
    /// </summary>
    /// <param name="pot"></param>
    void OnCollisionEnter(Collision pot)
    {
        if(burnablePotion == pot.gameObject)
        {
            GameObject.Find("BurnSound").GetComponent<AudioSource>().Play();
            GameObject.Find("ShatterSound").GetComponent<AudioSource>().Play();
            GameObject.Find("RigidBodyFPSController").GetComponent<PlayerScript>().potList.Remove(burnablePotion);
            //GameObject.Find("Fire").GetComponent<ParticleSystem>().Play();
            Destroy(burnablePotion);
            gameObject.SetActive(false);
        }
    }

}
