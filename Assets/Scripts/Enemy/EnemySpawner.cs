using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [System.Serializable]
    public class SpawnWave
    {
        public GameObject[] enemyPrefabs;
        public float spawnRate = 2f; // Seconds between spawns
        public float duration = 300f; // How long this wave lasts (optional)
    }

    public SpawnWave[] spawnWaves;
    public float spawnDistance = 10f;
    private Transform player;
    private float currentWaveEndTime = 0f;
    private int currentWaveIndex = -1;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    public void StartWave(int waveIndex)
    {
        if (waveIndex >= spawnWaves.Length) return;

        CancelInvoke(); // Stop previous wave

        currentWaveIndex = waveIndex;
        currentWaveEndTime = Time.time + spawnWaves[waveIndex].duration;

        InvokeRepeating("SpawnEnemy", spawnWaves[waveIndex].spawnRate, spawnWaves[waveIndex].spawnRate);
    }

    void Update()
    {
        if (currentWaveIndex >= 0 && Time.time >= currentWaveEndTime)
        {
            CancelInvoke();
        }
    }

    void SpawnEnemy()
    {
        if (currentWaveIndex < 0 || currentWaveIndex >= spawnWaves.Length) return;

        Vector2 spawnPosition = player.position + (Vector3)Random.insideUnitCircle.normalized * spawnDistance;
        GameObject enemyPrefab = spawnWaves[currentWaveIndex].enemyPrefabs[Random.Range(0, spawnWaves[currentWaveIndex].enemyPrefabs.Length)];
        Instantiate(enemyPrefab, spawnPosition, Quaternion.identity);
    }
}
