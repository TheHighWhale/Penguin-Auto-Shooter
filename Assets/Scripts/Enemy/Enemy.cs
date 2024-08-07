using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public EnemyData enemyData;

    private void Update()
    {
        if(enemyData.health <=0)
        {
            Death();
        }
    }

    private void Death()
    {
        Destroy(gameObject);
        if (Random.value >= 0.25f)
        {
            Instantiate(enemyData.xpData.xpPrefab, transform.position, Quaternion.identity);
        }
    }
}
