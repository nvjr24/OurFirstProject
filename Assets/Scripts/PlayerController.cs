using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerController : Controller
{
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float side = Input.GetAxis("side");  // Input for the A and D key left and right
        float up = Input.GetAxis("up"); // Input for the W and S key up and down

        Vector3 Move = new Vector3(side, up, 0);
        Move = Move.normalized;  // set to balence speed diagonally

       
        pawn.Movement(Move);// Calling for the pawn to Move
    }
}
