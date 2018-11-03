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

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "RoomObject")
        {
            ps.effectList.Add(Instantiate(bounceEffect, transform.position + transform.up / 10, transform.rotation));
            ps.potList.Remove(gameObject);
            Destroy(gameObject);
        }
    }
}
