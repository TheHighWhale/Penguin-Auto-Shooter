using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class ProjectileData : ScriptableObject
{
    public float damage;
    public float speed;
    public int amountPerBurst;
    public float spawnRate;
}
