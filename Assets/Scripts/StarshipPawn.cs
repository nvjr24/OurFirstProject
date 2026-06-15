using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarshipPawn :Pawn
{
    private Transform tf;

    public void Start()
    {
        tf = GetComponent<Transform>();
    }
    public override void Movement(Vector3 Move)
    {
        tf.position = tf.position + (Move * speed * Time.deltaTime);
    }
}
