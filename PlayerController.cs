using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    Rigidbody2D rigidbody;
    public float speed;
    private float defaultSpeed;
 

    void Start()
    {
        defaultSpeed = speed;
        rigidbody = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        float hor = Input.GetAxis("Horizontal");
        rigidbody.velocity = new Vector2(hor * defaultSpeed , rigidbody.velocity.y);

        if(Input.GetKey(KeyCode.LeftShift))
        {
            defaultSpeed = 3;
        }
        else
        {
            defaultSpeed = speed;
        }
    }
}
