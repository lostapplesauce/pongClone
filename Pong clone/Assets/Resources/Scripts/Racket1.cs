using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Racket1 : MonoBehaviour
{
    public float speed;

    private void FixedUpdate()
    {
        
        float vertical = Input.GetAxisRaw("Vertical");

        GetComponent<Rigidbody2D>().velocity = new Vector2(0, vertical) * speed;
    }
}

