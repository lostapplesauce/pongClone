using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Score : MonoBehaviour
{
    private int scorePlayer1 = 0;
    private int scorePlayer2 = 0;

    public int goalToWin;

    public GameObject ball;
    public Text score1;
    public Text score2;

    private void Update()
    {
        if(scorePlayer1 >= goalToWin || scorePlayer2 >= goalToWin)
        {
            SceneManager.LoadScene("GameOver");
        }
    }

    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.CompareTag("WallRight"))
        {
            scorePlayer1++;
            score1.text = scorePlayer1.ToString();
        }
        else if (col.gameObject.CompareTag("WallLeft"))
        {
            scorePlayer2++;
            score2.text = scorePlayer2.ToString();
        }
    }
}
