using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabs;
    public int animalIdx;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       if(Input.GetKeyDown(KeyCode.S)){
            Instantiate(animalPrefabs[animalIdx], new Vector3(0, 0, 20), animalPrefabs[animalIdx].transform.rotation);
       } 
    }
}
