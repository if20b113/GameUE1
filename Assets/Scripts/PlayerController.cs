using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float speed = 20.0f;
    private float turnSpeed = 45.0f;
    private float horizontalInput;
    private float forwardInput;
    public Camera TpsCamera;
    public Camera FpsCamera;
    public KeyCode SwitchKey;
    public string inputID;



    // Start is called before the first frame update
    void Start()
    {

        TpsCamera.enabled = true;
        FpsCamera.enabled = false;


    }

    // Update is called once per frame
    void Update()
    {
        // This is where we get player input
        horizontalInput = Input.GetAxis("Horizontal" + inputID);
        forwardInput = Input.GetAxis("Vertical" + inputID);

        //Moves the car forward based on the vertical input
        transform.Translate(Vector3.forward* Time.deltaTime * speed * forwardInput);
        // Rotates the car based on horizontal input
        transform.Rotate(Vector3.up, turnSpeed * horizontalInput * Time.deltaTime);


        if (Input.GetKeyDown(SwitchKey))
        {
            TpsCamera.enabled = !TpsCamera.enabled;
            FpsCamera.enabled = !FpsCamera.enabled;
        }
    }
}
