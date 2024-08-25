using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WhaleEnemy : MonoBehaviour
{
    public int health = 15;
    public float speed = 1.5f;
    public float moveFrequency = 1f; // How often it moves horizontally
    public float verticalDropAmount = 1f; // How much it moves downwards

    private Transform player;
    private Vector2 moveDirection = Vector2.right;
    private float nextMoveTime;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    void Update()
    {
        MoveInPattern();
    }

    private void MoveInPattern()
    {
        if (Time.time >= nextMoveTime)
        {
            transform.Translate(moveDirection * speed * Time.deltaTime);

            // Check for screen boundaries
            if (transform.position.x > Camera.main.orthographicSize || transform.position.x < -Camera.main.orthographicSize)
            {
                moveDirection = -moveDirection; // Change direction
                transform.Translate(Vector2.down * verticalDropAmount); // Move downwards
            }

            nextMoveTime = Time.time + moveFrequency;
        }
    }

    public void TakeDamage(int damage)
    {
        health -= damage;
        if (health <= 0)
        {
            Die();
        }
    }

    private void Die()
    {
        // Implement XP drop or other effects
        Destroy(gameObject);
    }
}
