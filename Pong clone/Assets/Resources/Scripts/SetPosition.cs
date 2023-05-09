using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetPosition : MonoBehaviour
{
    public Vector2 startPosition;

    public void Awake()
    {
        startPosition = transform.position;
    }

    private void OnTriggerEnter2D(Collider2D hit)
    {
        if (hit.gameObject.CompareTag("ScoreWall"))
        {
            transform.position = startPosition;
        }
    }
}
