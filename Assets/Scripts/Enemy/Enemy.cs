using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float health = 20f;
    public float speed = 2f;
    public Transform player;
    public Vector2 movementPattern;

    private Vector2 direction;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    void Update()
    {
        Move();
    }

    public void TakeDamage(int damage)
    {
        health -= damage;
        if (health <= 0)
        {
            Die();
        }
    }

    private void Move()
    {
        if (movementPattern == Vector2.zero) return;

        if (movementPattern == Vector2.one)
        {
            direction = (player.position - transform.position).normalized; // Move towards the player
        }
        else
        {
            direction = movementPattern.normalized;
        }

        transform.Translate(direction * speed * Time.deltaTime);
    }

    private void Die()
    {
        // Implement drop of XP or other items here
        Destroy(gameObject);
    }
}
