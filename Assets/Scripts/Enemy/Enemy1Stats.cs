using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy1Stats : MonoBehaviour
{
    public float health = 50f;
    public float speed = 1f;
    public float damage = 2f;
    public GameObject smallXP;

    void Start()
    {
        
    }

    void Update()
    {
        Death();
    }

    private void Death()
    {
        if(health <= 0)
        {
            Destroy(gameObject);
            if (Random.value >= 0.25f)
            {
                Instantiate(smallXP, transform.position, Quaternion.identity);
            }
            
        }
    }
}
