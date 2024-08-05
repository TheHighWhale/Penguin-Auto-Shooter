using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy1Stats : MonoBehaviour
{
    public float health = 100f;
    public float speed = 1f;
    public float damage = 2f;
    public GameObject smallXP;

    private Projectile1 projectile;


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
            //Instantiate(smallXP,)
        }
    }
}
