using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BounceScript : MonoBehaviour {
    
    public GameObject bounceEffect;
    GameObject player;
    PlayerScript ps;

    // Use this for initialization
    void Start()
    {
        player = GameObject.FindWithTag("Player");
        ps = player.GetComponent<PlayerScript>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    /// <summary>
    /// Spawns a bounce area upon colliding with specified objects
    /// </summary>
    /// <param name="other"></param>
    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "RoomObject")
        {
            ps.effectList.Add(Instantiate(bounceEffect, transform.position, other.gameObject.transform.rotation));
            GameObject.Find("ShatterSound").GetComponent<AudioSource>().Play();
            ps.potList.Remove(gameObject);
            Destroy(gameObject);
        }
        else if(other.gameObject.tag != "Player")
        {
            GameObject.Find("ShatterSound").GetComponent<AudioSource>().Play();
            ps.potList.Remove(gameObject);
            Destroy(gameObject);
        }
    }
}
