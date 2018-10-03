using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour {
	//player references and variables
	public GameObject potion;
    private bool firstIng;
    private bool secondIng;
    private string potReady;

    //input and potion tracking
    private List<string> inputs;
    public List<GameObject> potList;

    //manipulating player
    public Vector3 pos;
    public Vector3 direction;
    public Vector3 velocity;

    // Use this for initialization
    void Start () {
        firstIng = false;
        secondIng = false;
        potReady = "";
	}
	
	// Update is called once per frame
	void Update () {
        pos = transform.position;

        if (Input.GetKeyDown("1") && !firstIng)
        {
            firstIng = true;
        }
        if (Input.GetKeyDown("2") && !secondIng)
        {
            secondIng = true;
        }

        if(firstIng && secondIng)
        {
            potReady = "fire";
        }

        if (Input.GetMouseButtonDown(0) && potReady == "fire")
        {
            ThrowPotion();
            firstIng = false;
            secondIng = false;
            potReady = "";
        }
        /*
        Bounce();
        pos += velocity * Time.deltaTime;
        transform.position = pos;
        */
    }

	void ThrowPotion(){
        if (potList.Count <1)
        {
            potList.Add(Instantiate(potion, transform.position + transform.right.normalized/4, transform.rotation));
        }
	}

    void Bounce()
    {
        GameObject bounceArea = GameObject.Find("bounceTest");

        if (bounceArea != null)
        {
            if (bounceArea.GetComponent<Collider>().bounds.Intersects(this.GetComponent<Collider>().bounds))
            {
                velocity.y = 20;


            }
            else
            {
                velocity.y = velocity.y * .98f;
            }
        }
    }
}
