using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyObject : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    float destroyTime = 5;
    void Update()
    {
        Destroy(gameObject, destroyTime);
    }
}
