using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playerrun : MonoBehaviour
{

    Rigidbody2D rigidbody1;
    public float speed;
    private float defaultSpeed;

    void Start()
    {
        defaultSpeed = speed;
        rigidbody1 = GetComponent<Rigidbody2D>();
    }


    void FixedUpdate()
    {
        float hor = Input.GetAxis("Horizontal");
        rigidbody1.velocity = new Vector2(hor * defaultSpeed, rigidbody1.velocity.y);

        if(Input.GetKey(KeyCode.LeftShift))
        {
            defaultSpeed = 5;
        }
        else
        {
            defaultSpeed = speed;
        }
    }
}
