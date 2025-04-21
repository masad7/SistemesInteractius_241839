using System.Collections;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject flowerPrefab;
    public float spawnInterval = 10f;
    public float spawnRange = 10f;

    void Start()
    {
        InvokeRepeating("SpawnFlower", 2f, spawnInterval);
    }

    void SpawnFlower()
    {
        Vector3 randomPos = new Vector3(
            Random.Range(-spawnRange, spawnRange),
            0,
            Random.Range(-spawnRange, spawnRange)
        );

        Instantiate(flowerPrefab, randomPos, Quaternion.identity);
    }
}