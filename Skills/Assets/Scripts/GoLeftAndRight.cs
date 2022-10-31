using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoLeftAndRight : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private float speed = 40f;
    public static float topBound = 8;
    public  float bottomBound = 0;

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x > bottomBound) {
            transform.Translate(Vector3.left * Time.deltaTime * speed);
        }
        else if (transform.position.x < topBound) {
            transform.Translate(Vector3.right * Time.deltaTime * speed);
        }
    }
}
