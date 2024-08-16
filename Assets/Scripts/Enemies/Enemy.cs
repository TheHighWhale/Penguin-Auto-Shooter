using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Enemy : MonoBehaviour
{
    public float health;
    public float speed;
    public GameObject xpPickup;

    protected virtual void Start()
    {

    }

    protected virtual void Update()
    {

    }

    public virtual void TakeDamage(float amount)
    {
        health -= amount;
        if(health <= 0)
        {
            Die();
        }
    }

    protected virtual void Die()
    {
        // Drop XP logic here
        Destroy(gameObject);
    }
}
