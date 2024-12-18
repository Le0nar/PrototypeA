using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float speeed = 25.0f;
    private float turnRight = 25.0f;
    private float horizontalInput;
    private float forwardInputl;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Where is we get input values
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInputl = Input.GetAxis("Vertical");

        // It moves vehicle
        transform.Translate(Vector3.forward * Time.deltaTime * speeed * forwardInputl);
        // It rotate vehicle
        transform.Rotate(Vector3.up, Time.deltaTime * turnRight * horizontalInput);
    }
}
