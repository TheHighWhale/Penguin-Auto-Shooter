using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public float speed = 3f;
    private Transform player;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    void Update()
    {
        if (player == null)
            return;

        Vector2 direction = player.position - transform.position;
        direction.Normalize();
        GetComponent<Rigidbody2D>().velocity = direction * speed;
    }
}

