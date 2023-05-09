using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComputerPaddle : MonoBehaviour
{
    public GameObject ball;
    public float speed;
    // Start is called before the first frame update

    private void FixedUpdate()
    {
        //GetComponent<Rigidbody2D>().velocity = new Vector2(0, ball.transform.position.y - gameObject.GetComponent<Rigidbody2D>().transform.position.y) * speed;
        
        if(Mathf.Abs(this.transform.position.y - ball.transform.position.y) > 50)
        {
            if(transform.position.y < ball.transform.position.y)
            {
                GetComponent<Rigidbody2D>().velocity = new Vector2(0, 1) * speed;
            }
            else
            {
                GetComponent<Rigidbody2D>().velocity = new Vector2(0, -1) * speed;
            }
        } 
        else 
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(0, 0);
        }
    }
}

