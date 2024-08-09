using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Enemy : MonoBehaviour
{
    public float health;
    public float speed;
    public int xpValue;

    public abstract void Move();
    public abstract void Shoot();
    public abstract void Die();
}
