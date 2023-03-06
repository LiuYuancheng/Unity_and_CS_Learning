using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectColllisions : MonoBehaviour
{
    private GameManager gameManager;
    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>(); 
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other){


        if(other.CompareTag("Player")){
            gameManager.AddLives(-1);
           Destroy(gameObject);
           //Debug.Log("Game over!!!");
        } else if(other.CompareTag("Animal")) {
            //gameManager.AddScore(1);
            other.GetComponent<AnimalHunger>().FeedAnimal(1);
            Destroy(gameObject);
            //Destroy(other.gameObject);
        }
    }
}
