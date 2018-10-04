using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetScript : MonoBehaviour {

    GameObject player;
    [SerializeField] GameObject spawnPoint;

	// Use this for initialization
	void Start () {
        player = GameObject.Find("RigidBodyFPSController");
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnCollisionEnter(Collision other)
    {
        if (player == other.gameObject)
        {
            player.transform.position = spawnPoint.transform.position;
        }
    }
}
