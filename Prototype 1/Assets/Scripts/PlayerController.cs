using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
private float speed = 20;
private float turnSpeed = 45;
private float horizontalInput;
private float forwardInput;


    void Update(){
        forwardInput = Input.GetAxis("Vertical");
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.forward * Time.deltaTime * speed* forwardInput);
        transform.Rotate(Vector3.up * Time.deltaTime * turnSpeed *horizontalInput);
    }
}
