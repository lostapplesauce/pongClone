using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour
{
    public float movementSpeed;
    public float extraSpeedPerHit;
    public float maxExtraSpeed;

    //Helper variable
    int hitCounter = 0;
    
    /*
     This is just idea about bouncing:
        Referene to the walls on Bottom and Top
        Calculate Direction = destination - source

        
        Calculate bounce direction
        Calculate the angle using Inverse Tangent Method
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg - 90; 
        // -90 due to Unit circle in Unity starting at top and going clockwise 0 90 180 270 360
     */

    // Start is called before the first frame update

    void Start()
    {
        StartCoroutine(StartBall());
    }

    void PositionBall(bool isStartingPLayer1)
    {
        this.GetComponent<Rigidbody2D>().velocity = new Vector2(0, 0);

        if (isStartingPLayer1)
        {
            this.gameObject.transform.localPosition = new Vector3(-69, -73, 0);
        }
        else
        {
            this.gameObject.transform.localPosition = new Vector3(-176, -73, 0);
        }
    }

    public IEnumerator StartBall(bool isStartingPlayer1 = true)
    {
        this.PositionBall(isStartingPlayer1);

        hitCounter = 0;

        yield return new WaitForSeconds(2);
        if (isStartingPlayer1)
            MoveBall(new Vector2(-1, 0));
        else
        {
            MoveBall(new Vector2(1, 0));
        }


    }

    public void MoveBall(Vector2 dir)
    {
        dir = dir.normalized; //normalized returns vector with magnitude of 1
        
        float speed = movementSpeed + hitCounter * extraSpeedPerHit;
        Rigidbody2D rigidbody2D = gameObject.GetComponent<Rigidbody2D>();

        rigidbody2D.velocity = dir * speed;
    }
    

    public void IncreaseHitCounter()
    {
        if(hitCounter * extraSpeedPerHit <= maxExtraSpeed)
        {
            
            hitCounter++;
        }
    }

}
