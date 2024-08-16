using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SealEnemy : Enemy
{
    private GameObject player;

    protected override void Start()
    {
        player = GameObject.FindWithTag("Player");
        speed = 2;
    }

    protected override void Update()
    {
        Vector3 playerDirection = player.transform.position - transform.position;
        playerDirection.Normalize();

        transform.Translate(playerDirection * speed * Time.deltaTime);
    }
}
