using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HazardSpawner : MonoBehaviour
{
    public GameObject hazardPrefab; // Assign hazard prefab
    public int hazardCount = 5; // Number of hazards to spawn
    public float spawnRangeX = 5f; // Random X range
    public float spawnRangeZ = 5f; // Random Z range
    public float spawnHeight = 1f; // Spawn at a fixed height

    void Start()
    {
        SpawnHazards();
    }

    void SpawnHazards()
    {
        for (int i = 0; i < hazardCount; i++)
        {
            Vector3 spawnPosition = new Vector3(
                Random.Range(-spawnRangeX, spawnRangeX), // Random X
                spawnHeight, // Fixed Y position
                Random.Range(-spawnRangeZ, spawnRangeZ)  // Random Z
            );

            Instantiate(hazardPrefab, spawnPosition, Quaternion.identity);
        }
    }
}
