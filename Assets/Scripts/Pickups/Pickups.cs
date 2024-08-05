using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickups : MonoBehaviour
{
    private PlayerStats playerStats;
    private int smallXP = 50;
    private int mediumXP = 100;
    private int largeXP = 200;

    void Start()
    {
        playerStats = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerStats>();
    }

    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            switch(tag)
            {
                case "SmallXP":
                    playerStats.xp += smallXP;
                    break;
                case "MediumXP":
                    playerStats.xp += mediumXP;
                    break;
                case "LargeXP":
                    playerStats.xp += largeXP;
                    break;
                default:
                    Debug.LogWarning("Unkown XP type: " + tag);
                    break;
            }

            Destroy(gameObject);
        }
    }
}
