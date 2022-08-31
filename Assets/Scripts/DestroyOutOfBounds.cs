using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    public float lowerBound;
    public float topBound;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.z > topBound) {
            DestroyObject(gameObject);
        } else if (transform.position.z < lowerBound)
        {
            DestroyObject(gameObject);
        }
    }
}
