using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SealEnemy : MonoBehaviour
{
    public int health = 20;
    public float speed = 2f;

    private Transform player;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    void Update()
    {
        FollowPlayer();
    }

    private void FollowPlayer()
    {
        Vector2 direction = (player.position - transform.position).normalized;
        transform.Translate(direction * speed * Time.deltaTime);
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
