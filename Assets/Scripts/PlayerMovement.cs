using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float horizontalInput;
    public float verticalInput;
    public float turnspeed = 5000;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");

        // Move the object
        transform.Translate(Vector3.forward * Time.deltaTime * verticalInput);
        //transform.Translate(-Vector3.right * Time.deltaTime * horizontalInput);
        transform.Rotate(Vector3.up * horizontalInput * turnspeed * Time.deltaTime);
    }
}
