using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public string inputID;
    public float speed= 5f;
    public float turnSpeed = 45f;
    public float horizontalInput;
    public float forwadInput;

    public Camera mainCamera;
    public Camera hoodCamera;
    public KeyCode switchKey;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal"+inputID);
        forwadInput = Input.GetAxis("Vertical"+inputID);
        transform.Translate(Vector3.forward*Time.deltaTime*speed*forwadInput);
        //transform.Translate(Vector3.right*Time.deltaTime*turnSpeed*horizontalInput);
        transform.Rotate(Vector3.up, turnSpeed*horizontalInput*Time.deltaTime);

        if(Input.GetKeyDown(switchKey)){
            mainCamera.enabled = !mainCamera.enabled;
            hoodCamera.enabled = !hoodCamera.enabled;
        }
     }
}
