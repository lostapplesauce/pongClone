using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Racket2 : MonoBehaviour
{

    // Start is called before the first frame update
    public float speed;

    private void FixedUpdate()
    {
        float vertical = Input.GetAxisRaw("Vertical2");

        GetComponent<Rigidbody2D>().velocity = new Vector2(0, vertical) * speed;
    }
}
