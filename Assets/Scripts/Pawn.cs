using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Pawn : MonoBehaviour
{
    public float speed = 1f;
    

    public abstract void Movement(Vector3 Move);
    
}

