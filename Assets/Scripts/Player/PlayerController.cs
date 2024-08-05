using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 5f;

    void Start()
    {

    }

    private void Update()
    {
        Vector2 direction = Vector2.zero;

        if (Input.GetKey(KeyCode.W))
        {
            direction.y = 1;
        }

        if(Input.GetKey(KeyCode.A))
        {
            direction.x = -1;
        }

        if(Input.GetKey(KeyCode.S))
        {
            direction.y = -1;
        }

        if(Input.GetKey(KeyCode.D))
        {
            direction.x = 1;
        }

        GetComponent<Rigidbody2D>().velocity = speed * direction;
        direction.Normalize();
    }
}
