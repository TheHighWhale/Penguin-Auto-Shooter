using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public EnemySpawner enemySpawner;
    public float elapsedTime = 0f;
    public float spawnWaveInterval = 300f; // 5 minutes interval for new enemy types
    public float gameDuration = 1800f; // 30 minutes for the entire game

    private bool isGameOver = false;

    void Start()
    {
        // Start with the first wave of enemies
        enemySpawner.StartWave(0);
    }

    void Update()
    {
        if (isGameOver) return;

        elapsedTime += Time.deltaTime;

        // Check for new enemy waves based on elapsed time
        if (elapsedTime >= spawnWaveInterval)
        {
            int waveIndex = Mathf.FloorToInt(elapsedTime / spawnWaveInterval);
            enemySpawner.StartWave(waveIndex);
        }

        // Check if the player has survived for the entire duration
        if (elapsedTime >= gameDuration)
        {
            EndGame(true);
        }
    }

    public void EndGame(bool won)
    {
        isGameOver = true;
        // Handle end of game logic here
        // E.g., show win/lose screen, stop player movement, etc.
        Debug.Log(won ? "Player Survived!" : "Player Died!");
    }

    public void OnPlayerDeath()
    {
        EndGame(false);
    }
}
