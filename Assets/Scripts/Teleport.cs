using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour
{
    private Transform tf;// A variable to hold the transform component
    // Start is called before the first frame update
    void Start()
    {
        // Get the transform component
        tf = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        // Move target back to origin when the T key is pressed
        if (Input.GetKeyDown(KeyCode.T))
        {

            tf.position = Vector3.zero; // Zero is a preset of (0,0,0)
        }
    }
}
