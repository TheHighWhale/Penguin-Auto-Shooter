using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Projectile : MonoBehaviour
{
    public float speed;
    public float damage;

    public abstract void Move();
    public abstract void OnHit(Collider2D other);
}
