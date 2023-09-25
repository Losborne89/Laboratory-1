using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float speed = 30f;
    private float turnSpeed = 60f;
    private float horizontalInput;
    private float forwardInput;
    public GameObject mainCamera;
    public GameObject reverseCamera;
    private bool isReverseCameraActive = false;

    // Start is called before the first frame update
    void Start()
    {
        mainCamera.SetActive(true);
        reverseCamera.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");

        // Moves the vehicle forward based on vertical input
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);

        // Rotates the car based on horizontal input
        transform.Rotate(Vector3.up, turnSpeed * horizontalInput * Time.deltaTime);

        // when C is pressed camera switches view
        if (Input.GetKeyDown(KeyCode.C))
        {
            if(isReverseCameraActive == true)
            {
                mainCamera.SetActive(false);
                reverseCamera.SetActive(true);
                isReverseCameraActive = false;
            }
            else
            {
                mainCamera.SetActive(true);
                reverseCamera.SetActive(false);
                isReverseCameraActive = true;
            }
          

        }


    }
}
