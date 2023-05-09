using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class BallBounce : MonoBehaviour
{

    public BallMovement ballMovement;
    

    void BounceFromRacket(Collision2D col)
    {
        
        Vector3 ballPosition = this.transform.position;
        Vector3 racketPosition = col.gameObject.transform.position;

        float racketHeight = col.collider.bounds.size.y;

        float x;

        if(col.gameObject.CompareTag("Player"))
        {
            x = 1;
        } else
        {
            x = -1;
        }

        float y = (ballPosition.y - racketPosition.y) / racketHeight;
        

        this.ballMovement.IncreaseHitCounter();
        this.ballMovement.MoveBall(new Vector2(x, y));
    }
    private void OnCollisionEnter2D(Collision2D coll)
    {
        if(coll.gameObject.CompareTag("Player") || coll.gameObject.CompareTag("Player2"))
        {
            this.BounceFromRacket(coll);
        } else if(coll.gameObject.CompareTag("WallLeft"))
        {
            StartCoroutine(this.ballMovement.StartBall(true));
        } else if(coll.gameObject.CompareTag("WallRight"))
        {
            StartCoroutine(this.ballMovement.StartBall(false));
        }
    }
}
