using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabs;
    public int animalIdx;
    private int spawnRangeX = 20;
    public float spawnRangZmin = 2;
    public float spawnRangZmax = 16;

    private int SpawnPosZ = 20;

    private float startDelay = 2;
    private float spawnInterval = 1.5f;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandDownAnimal", startDelay, spawnInterval);
        InvokeRepeating("SpawnRandLeftAnimal", startDelay, spawnInterval+1f);
        InvokeRepeating("SpawnRandRightAnimal", startDelay, spawnInterval+0.5f);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void SpawnRandDownAnimal(){
        Vector3 spwanPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0 , SpawnPosZ);
        int animalIdx = Random.Range(0, animalPrefabs.Length);
        Instantiate(animalPrefabs[animalIdx], spwanPos, animalPrefabs[animalIdx].transform.rotation);
    }

    void SpawnRandLeftAnimal(){
        Vector3 spwanPos = new Vector3(-spawnRangeX, 0 , Random.Range(spawnRangZmin, spawnRangZmax));
        int animalIdx = Random.Range(0, animalPrefabs.Length);
        Instantiate(animalPrefabs[animalIdx], spwanPos, Quaternion.Euler(new Vector3(0, 90, 0)));
    }

    void SpawnRandRightAnimal(){
        Vector3 spwanPos = new Vector3(spawnRangeX, 0 , Random.Range(spawnRangZmin, spawnRangZmax));
        int animalIdx = Random.Range(0, animalPrefabs.Length);
        Instantiate(animalPrefabs[animalIdx], spwanPos, Quaternion.Euler(new Vector3(0, -90, 0)));
    }

}
