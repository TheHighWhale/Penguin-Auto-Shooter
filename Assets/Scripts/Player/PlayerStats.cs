using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : MonoBehaviour
{
    public float health = 100f;
    public int level = 1;
    public int xp = 0;
    public int maxXP = 200;
    private int excessXP = 0;

    void Start()
    {
    }

    void Update()
    {
        if(xp >= maxXP)
        {
            LevelUp();
        }

        if(health <= 0)
        {
            FindObjectOfType<GameManager>().OnPlayerDeath();
        }
    }

    public void TakeDamage(float damage)
    {
        health -= damage;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("XP"))
        {
            
        }
    }


    void LevelUp()
    {
        level++;
        int excess = xp - maxXP;   
        excessXP += excess;
        xp = excessXP;
        excessXP = 0;
        maxXP = Mathf.RoundToInt(maxXP * 1.2f);
        Debug.Log(level);
    }
}
