using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    public float spawnAfter = 0f;
    private float timeLeft = 0f;
 
    // Update is called once per frame
    void Update()
    {
        if (timeLeft > 0) {
            timeLeft -= Time.deltaTime;
        }
 
        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space) && timeLeft <= 0f)
        {
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
            timeLeft = spawnAfter;
            Debug.Log("");
        }
    }
}
