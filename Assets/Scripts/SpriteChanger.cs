using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteChanger : MonoBehaviour
{
    // Create a variable for the spriteRenderer
    public SpriteRenderer theRenderer;
    public Color spriteColor;
    // Start is called before the first frame update

    void Start()
    {
        // load component from target Renderer
        theRenderer = gameObject.GetComponent<SpriteRenderer>();
        // Change the color of the sprite
        spriteColor.a = 1.0f;
        // If color is set change color
        if (theRenderer != null)
        {
            theRenderer.color = spriteColor;

        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}
