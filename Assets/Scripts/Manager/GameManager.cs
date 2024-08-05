using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameManager : MonoBehaviour
{
    public TextMeshProUGUI timerText; // Reference to the UI text component
    private float timeLeft = 1800f; // 30 minutes in seconds
    public TextMeshProUGUI levelText;
    public TextMeshProUGUI xpText;
    private PlayerStats playerStats;
    private Enemy1Stats enemy1Stats;
    private int round = 1;
    private float difficultyTimer = 0f;

    private void Start()
    {
        playerStats = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerStats>();
        enemy1Stats = GameObject.FindGameObjectWithTag("Enemy").GetComponent<Enemy1Stats>();
    }

    void Update()
    {
        timeLeft -= Time.deltaTime;
        DisplayTime(timeLeft);
        DisplayLevel();
        difficultyTimer += Time.deltaTime;

        if (timeLeft <= 0)
        {
            // Game Over logic here
            Debug.Log("Game Over!");
            // Add your game over actions, like loading a game over screen or quitting the game
        }

        if (difficultyTimer <= 20f)
        {
            difficultyTimer = 0f;
            IncreaseDifficulty();
        }
    }

    void DisplayTime(float timeToDisplay)
    {
        float minutes = Mathf.FloorToInt(timeToDisplay / 60);
        float seconds = Mathf.FloorToInt(timeToDisplay % 60);
        timerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);

    }

    void DisplayLevel()
    {
        levelText.text = "Level: " + playerStats.level.ToString();
        xpText.text = "XP: " + playerStats.xp.ToString();
    }

    void IncreaseDifficulty()
    {
        round++;
        enemy1Stats.health += 50f;
    }
}
