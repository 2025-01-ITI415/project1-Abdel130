using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectibleSpawner : MonoBehaviour
{
    public GameObject collectiblePrefab;
    public int collectibleCount = 5; // Number of collectibles to spawn
    public float spawnRangeX = 5f;
    public float spawnRangeZ = 5f;
    public float spawnHeight = 1f;

    void Start()
    {
        SpawnCollectibles();
    }

    void SpawnCollectibles()
    {
        for (int i = 0; i < collectibleCount; i++)
        {
            Vector3 spawnPosition = new Vector3(
                Random.Range(-spawnRangeX, spawnRangeX),
                spawnHeight,
                Random.Range(-spawnRangeZ, spawnRangeZ)
            );

            Instantiate(collectiblePrefab, spawnPosition, Quaternion.identity);
        }
    }
}
