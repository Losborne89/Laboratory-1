using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class VehicleObstacle : MonoBehaviour
{
    [SerializeField]
    private float speed = 30f;
    private float horizontalInput;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");

        // Moves the vehicle forward based on vertical input
        transform.Translate(Vector3.forward * Time.deltaTime * speed);

        // Rotates the car based on horizontal input
        transform.Rotate(Vector3.up, horizontalInput * Time.deltaTime);
    }
}
