using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    public int keyCount; 
    // Update is called once per frame
    void Update()
    {
        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space))
        {
            keyCount +=1;
            if(keyCount == 2){
                Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
                keyCount = 0;
            }
        }
    }
}
