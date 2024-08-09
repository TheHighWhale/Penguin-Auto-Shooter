using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public List<Enemy> enemyPrefabs;
    public float spawnInterval;
    public int currentWave = 1;

    private float spawnTimer;
    private Vector2 spawnPosition;

    void Update()
    {
        spawnTimer -= Time.deltaTime;
        if (spawnTimer <= 0)
        {
            SpawnEnemy();
            spawnTimer = spawnInterval;
        }
    }

    void SpawnEnemy()
    {
        // Logic to choose enemy based on wave
        Enemy enemyPrefab = enemyPrefabs[Random.Range(0, enemyPrefabs.Count)];
        Enemy enemy = Instantiate(enemyPrefab, spawnPosition, Quaternion.identity);
        // ...
    }
}
