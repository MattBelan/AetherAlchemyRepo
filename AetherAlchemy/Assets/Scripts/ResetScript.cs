using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetScript : MonoBehaviour {

    GameObject player;
    public int puzzleNum;

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
            Vector3 newPos;

            switch (puzzleNum)
            {
                case 3:
                    newPos = new Vector3(-0.13f, 4.29f, 69.5f);
                    player.transform.position = newPos;
                    break;
                case 4:
                    newPos = new Vector3(-0.13f, 2.03f, 99.76f);
                    player.transform.position = newPos;
                    break;
            }
        }
    }
}
