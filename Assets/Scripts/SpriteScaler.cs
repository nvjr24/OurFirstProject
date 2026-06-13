using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteScaler : MonoBehaviour
{
    private Transform tf; // Create a variable for our transform component
    public float maxScale;// Create a variable for the max we can scale in one frame draw
    public float speed = 1.0f; // Create a variable for the speed of the scale

    // Start is called before the first frame update
    void Start()
    {
        // Load our transform component into our variable
        tf = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
    // Find out how far and in which direction our axes are pressed
    float axesValue = Input.GetAxis("scale");
        // Use that value to calculatea value between -100 and 100% of our max scale per frame 
        float scaleAmount = axesValue * maxScale;
        // Increase the scaloe of our object by that amount on all axes (1,1,1) * scaleAmount 
        {
            tf.localScale += Vector3.one * scaleAmount * speed * Time.deltaTime;
        }


    }
}
