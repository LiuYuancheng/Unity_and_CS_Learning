using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float horizontalInput;
    public float verticalInput;
    public float speed = 10f;
    public float rangeX = 10f;
    public float rangeZmin = 2f;
    public float rangeZmax = 16f;
    
    public GameObject projectilePrefab;

    public Camera mainCamera;
    public Camera hoodCamera;
    public KeyCode switchKey;
    public Transform projectileSpawnPoint;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // keep the player in bounds 
        if(transform.position.x < -rangeX){
            transform.position = new Vector3(-rangeX, transform.position.y, transform.position.z);
        }
        if(transform.position.x > rangeX){
            transform.position = new Vector3(rangeX, transform.position.y, transform.position.z);
        }
        if(transform.position.z < rangeZmin){
            transform.position = new Vector3(transform.position.x, transform.position.y, rangeZmin);
        }

        if(transform.position.z > rangeZmax){
            transform.position = new Vector3(transform.position.x, transform.position.y, rangeZmax);
        }

        // movement control
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right*Time.deltaTime*speed*horizontalInput);
        
        verticalInput = Input.GetAxis("Vertical");
        transform.Translate(Vector3.forward*Time.deltaTime*speed*verticalInput);

        // through the pizza
        if(Input.GetKeyDown(KeyCode.Space)){
            Instantiate(projectilePrefab, projectileSpawnPoint.position, projectilePrefab.transform.rotation);
        }

         if(Input.GetKeyDown(switchKey)){
            mainCamera.enabled = !mainCamera.enabled;
            hoodCamera.enabled = !hoodCamera.enabled;

        }
    }
}
