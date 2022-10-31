using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlCamera : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    public float speed = 40f;
    public float horizontalInput;
    public float forwardInput;
    public GameObject foodPrefab = null;

    void Update()
    {
        forwardInput = Input.GetAxis("Vertical");
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.left * Time.deltaTime * speed* forwardInput);
        transform.Translate(Vector3.forward * Time.deltaTime * speed *horizontalInput);


        if (Input.GetKeyDown(KeyCode.Space) && foodPrefab != null) {
            //Instantiate(foodPrefab, transform.position, Quaternion.identity); //this will always spawn the object with the rotation set to (0, 0, 0)
            Instantiate(foodPrefab, transform.position, foodPrefab.transform.rotation); //this will always spawn the object with the rotation as set up in the prefab!
        }
    }

    
}
