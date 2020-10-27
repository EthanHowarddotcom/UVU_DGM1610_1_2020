using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    //Sets what objects will be spawned. (Horse, Chick, and Cow)
    public GameObject[] animalPrefabs; 

    //Sets the area on the X axis where animals will spawn. 
    private float spawnRangeX = 20.00f;

    //Sets where they will spawn on the Z axis
    private float spawnPosZ = 30; 

    //Sets when animals will spawn after game starts. 
    private float startDelay = 2.0f;

    //Sets the rate at which animals spawn
    private float spawnInterval = 1.5f;


    // Update is called once per frame
    void Start()
    {
        InvokeRepeating("SpawnRandAnimal", startDelay, spawnInterval);
        SpawnRandAnimal();
        //Spawns the animal, with the limits of the interval
        
    }
    void SpawnRandAnimal ()
    {   //Where the animal will spawn.
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ);
        {
            //Spawns the animal
            int animalIndex = Random.Range(0, animalPrefabs.Length);
            Instantiate(animalPrefabs[animalIndex], spawnPos, animalPrefabs[animalIndex].transform.rotation);
        }
    }
}
