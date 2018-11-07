using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {


    private Rigidbody rb;
    public float speed; 

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    //called before rendering a frame
    void Update()
	{
		//game code
	}

	//called before applying physics action
	void FixedUpdate()
	{
        //get input from player keyboard
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0, moveVertical);

        rb.AddForce(movement * speed);

	}

}
