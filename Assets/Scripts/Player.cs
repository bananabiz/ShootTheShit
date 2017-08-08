using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // <access-specifier> <data-type> <variable-name> (optional initialization);
    public int lives = 3;
    public float rotationSpeed = 2;
    public float acceleration = 20f;
    public float deceleration = 0.1f;

    private Rigidbody2D rigid; // default value null

	// Use this for initialization
    // <access-specifier> <return-type> <function-name> (<arguments>)
	void Start ()
    {
        rigid = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update ()
    {
        // if user presses W
        /*
        if (condition)
        {
           // statment A
        }
        */
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
        {
            rigid.AddForce(transform.right * acceleration);
        }
        if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
        {
            rigid.AddForce(-transform.right * acceleration);
        }
        // Decelerating
        /*
        Arithmetic Operators
        +, -, *, /
        +=, -=, *=, /=
        Logic Operators
        == (equal to)
        != (not equal to)
        && (AND)
        || (OR)
        */
        rigid.velocity = rigid.velocity + -rigid.velocity * deceleration;
        {
            if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
                transform.Rotate(0, 0, -rotationSpeed);
        }
        {
            if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
                transform.Rotate(0, 0, rotationSpeed);
        }
	}
}
