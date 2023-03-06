using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestropOutBounds : MonoBehaviour
{
    private float topBound = 30;
    private float lowerBound = -10;
    private float sideBound = 30;
    private GameManager gameManager;
    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.z > topBound){
            Destroy(gameObject);
        } else if(transform.position.z < lowerBound){
            Debug.Log("Miss one !");
            Destroy(gameObject);
        } else if(transform.position.x < -sideBound){
            Destroy(gameObject);
        } else if(transform.position.x > sideBound){
            Destroy(gameObject);
        }
    }
}
