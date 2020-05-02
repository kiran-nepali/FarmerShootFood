using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabs;
    public float spawnRangeX = 14f;
    public float spawnPosz = 16f;

    private float startDelay = 2f;
    private float spawnInterval = 2.5f;

    // Start is called before the first frame update
    void Start()
    {
        //Spawn Animals automatically
        InvokeRepeating("SpawnRandomAnimals", startDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {
        //Below code is used when you want to manually spawn animals by pressing key.
        //if (Input.GetKeyDown(KeyCode.S))
        //{
        //    SpawnRandomAnimals();
        //}
    }

    void SpawnRandomAnimals()
    {
        int animalIndex = Random.Range(0, animalPrefabs.Length);
        Instantiate(animalPrefabs[animalIndex], new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosz), animalPrefabs[animalIndex].transform.rotation);
    }
}
