using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabs;
    public int animalIdx;
    private int spawnRangeX = 20;
    private int SpawnPosZ = 20;

    private float startDelay = 2;
    private float spawnInterval = 1.5f;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandAnimal", startDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {
       if(Input.GetKeyDown(KeyCode.S)){
            SpawnRandAnimal();
       } 
    }

    void SpawnRandAnimal(){
        Vector3 spwanPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0 , SpawnPosZ);
        int animalIdx = Random.Range(0, animalPrefabs.Length);
        Instantiate(animalPrefabs[animalIdx], spwanPos, animalPrefabs[animalIdx].transform.rotation);
    }


}
