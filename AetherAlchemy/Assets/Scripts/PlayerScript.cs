using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour {
	//player references and variables
	public GameObject firePotion;
    public GameObject bouncePotion;
    public GameObject pushPotion;
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
        potReady = "";
        inputs = new List<string>();
	}
	
	// Update is called once per frame
	void Update () {
        pos = transform.position;

        //getting potion inputs
        if (Input.GetKeyDown("1") && inputs.Count<2)
        {
            if(inputs.Count < 2)
            {
                inputs.Add("1");
            }
            else
            {
                inputs.Clear();
                inputs.Add("1");
            }
        }
        if (Input.GetKeyDown("2") && inputs.Count < 2)
        {
            if (inputs.Count < 2)
            {
                inputs.Add("2");
            }
            else
            {
                inputs.Clear();
                inputs.Add("2");
            }
        }
        if (Input.GetKeyDown("3") && inputs.Count < 2)
        {
            if (inputs.Count < 2)
            {
                inputs.Add("3");
            }
            else
            {
                inputs.Clear();
                inputs.Add("3");
            }
        }

        //checking if potion is ready
        if (inputs.Count >= 2)
        {
            switch (inputs[0])  //First ingredient
            {
                case "1":
                    switch (inputs[1])  //Second Ingredient
                    {
                        case "1":       //Base with base = nothing
                            inputs.Clear();
                            break;
                        case "2":       //base with red(2) = fire
                            inputs.Clear();
                            potReady = "fire";
                            break;
                        case "3":       //base with blue/green(3) = bounce
                            inputs.Clear();
                            potReady = "bounce";
                            break;
                    }
                    break;
                case "2":
                    switch (inputs[1])
                    {
                        case "1":       //fire + base
                            inputs.Clear();
                            potReady = "fire";
                            break;
                        case "2":       //fire+fire = nothing
                            inputs.Clear();
                            break;
                        case "3":       //fire + bounce = push
                            inputs.Clear();
                            potReady = "push";
                            break;
                    }
                    break;
                case "3":
                    switch (inputs[1])
                    {
                        case "1":       //bounce+ base
                            inputs.Clear();
                            potReady = "bounce";
                            break;
                        case "2":       //bounce + fire
                            inputs.Clear();
                            potReady = "push";
                            break;
                        case "3":       //bounce + bounce = nothing
                            inputs.Clear();
                            break;
                    }
                    break;
            }
        }

        if (Input.GetMouseButtonDown(0))
        {
            switch (potReady)
            {
                case "fire":
                    ThrowPotion();
                    GetComponent<AudioSource>().Play();
                    potReady = "";
                    break;
                case "bounce":
                    break;
                case "push":
                    break;
            }
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
            potList.Add(Instantiate(firePotion, transform.position + transform.right.normalized/4 + transform.up/2, transform.rotation));
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
