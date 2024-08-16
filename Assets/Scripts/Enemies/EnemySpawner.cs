using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public List<Enemy> enemyPrefabs;
    public float spawnInterval;
    public Camera mainCam;
    public float spawnDistance = 1f;

    private float spawnTimer = 1;

    private void Start()
    {
        if(mainCam == null)
        {
            mainCam = Camera.main;
        }
    }

    void Update()
    {
        spawnTimer += Time.deltaTime;

        if (spawnTimer >= spawnInterval)
        {
            spawnTimer = 0;
            SpawnEnemy();
        }
    }

    void SpawnEnemy()
    {
        float cameraHalfWidth = mainCam.orthographicSize * mainCam.aspect;
        float cameraHalfHeight = mainCam.orthographicSize;

        int side = Random.Range(0, 4);

        Vector3 spawnPosition;
        switch (side)
        {
            case 0: // camera top
                spawnPosition = new Vector3(Random.Range(-cameraHalfWidth, cameraHalfWidth), cameraHalfHeight + spawnDistance, 0);
                break;
            case 1: // camera right
                spawnPosition = new Vector3(cameraHalfWidth + spawnDistance, Random.Range(-cameraHalfHeight, cameraHalfHeight), 0);
                break;
            case 2: // camera bottom
                spawnPosition = new Vector3(Random.Range(-cameraHalfWidth, cameraHalfWidth), -cameraHalfHeight - spawnDistance, 0);
                break;
            default: // camera left
                spawnPosition = new Vector3(-cameraHalfWidth - spawnDistance, Random.Range(-cameraHalfHeight, cameraHalfHeight), 0);
                break;
        }

        // Logic to choose enemy based on wave
        //Enemy enemyPrefab = enemyPrefabs[Random.Range(0, enemyPrefabs.Count)];
        //Enemy enemy = Instantiate(enemyPrefab, spawnPosition, Quaternion.identity);
        // ...
    }
}
