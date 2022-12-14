using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] bloonaPrefabs;
    public float startDelay = 0.5f;
    public float spawnInterval = 1.5f;
    public float xRange = 10.0f;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomBloona", startDelay, spawnInterval);
    }

    // Update is called once per frame
    void SpawnRandomBloona()
    {
        // gets random position on axis
        Vector3 spawnPos = new Vector3(Random.Range(-xRange,xRange),10,0);
        // picks bloona off array
        int bloonaIndex = Random.Range(0,bloonaPrefabs.Length);
        //spawns bloona at spawn position

        Instantiate(bloonaPrefabs[bloonaIndex], spawnPos, bloonaPrefabs[bloonaIndex].transform.rotation);

    }
}
