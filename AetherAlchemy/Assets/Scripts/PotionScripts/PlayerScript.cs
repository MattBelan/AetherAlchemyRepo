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
    public List<GameObject> effectList;

    //manipulating player
    public Vector3 pos;
    public Vector3 direction;
    public Vector3 velocity;
    Rigidbody playerRigid;
    bool onBounce;

    bool hasGem;

    // Use this for initialization
    void Start () {
        potReady = "";
        inputs = new List<string>();
        playerRigid = GetComponent<Rigidbody>();
        onBounce = false;
        hasGem = true;
	}
	
	// Update is called once per frame
	void Update () {
        pos = transform.position;

        ProcessInput();
        LimitEffects();
    }

	void ThrowFire(){
        if (potList.Count <1)
        {
            potList.Add(Instantiate(firePotion, transform.position + transform.right.normalized/4 + transform.up/2, transform.rotation));
        }
	}

    void ThrowBounce()
    {
        if (potList.Count < 1 && hasGem)
        {
            potList.Add(Instantiate(bouncePotion, transform.position + transform.right.normalized / 4 + transform.up / 2, transform.rotation));
        }
    }

    void ThrowPush()
    {
        if (potList.Count < 1 && hasGem)
        {
            potList.Add(Instantiate(pushPotion, transform.position + transform.right.normalized / 4 + transform.up / 2, transform.rotation));
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "bounceArea")
        {
            onBounce = true;
            if (playerRigid.velocity.y < -3)
            {
                Vector3 newVelocity = playerRigid.velocity;
                newVelocity.y = -newVelocity.y;

                playerRigid.velocity = newVelocity;
            }
        }
        if(other.gameObject.tag == "PushArea")
        {

        }
    }

    void OnTriggerExit(Collider other)
    {
        if(other.gameObject.tag == "bounceArea")
        {
            onBounce = false;
        }
    }

    void ProcessInput()
    {
        //getting potion inputs
        if (Input.GetKeyDown("1") && inputs.Count < 2)
        {
            if (inputs.Count < 2)
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
            if(potReady != "")
            {
                switch (potReady)
                {
                    case "fire":
                        ThrowFire();
                        break;
                    case "bounce":
                        ThrowBounce();
                        break;
                    case "push":
                        ThrowPush();
                        break;
                }
                GetComponent<AudioSource>().Play();
                potReady = "";
            }
        }


        if (Input.GetKeyDown("space") && onBounce && playerRigid.velocity.y == 0)
        {
            playerRigid.AddForce(0, 30.0f, 0, ForceMode.Impulse);
        }

        AirMovement();
    }

    void LimitEffects()
    {
        if (effectList.Count > 2)
        {
            GameObject effect = effectList[0];
            effectList.Remove(effectList[0]);
            Destroy(effect);
        }
    }

    void AirMovement()
    {
        if (playerRigid.velocity.y != 0)
        {
            if (Input.GetKeyDown("a"))
            {
                playerRigid.velocity -= transform.right*4;
            }
            if (Input.GetKeyDown("d"))
            {
                playerRigid.velocity += transform.right*4;
            }
            if (Input.GetKeyDown("w"))
            {
                playerRigid.velocity += transform.forward*4;
            }
            if (Input.GetKeyDown("s"))
            {
                playerRigid.velocity -= transform.forward*4;
            }
        }
    }

    public void PickUpGem()
    {
        hasGem = !hasGem;
    }
}
