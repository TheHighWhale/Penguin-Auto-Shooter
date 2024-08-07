using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class EnemyData : ScriptableObject
{
    public string enemyName;
    public float health;
    public float damage;
    public float speed;
    public XPData xpData;
}
