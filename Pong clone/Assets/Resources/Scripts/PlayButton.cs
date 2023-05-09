using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayButton : MonoBehaviour
{
    public void OnButtonPressed()
    {
        //This Class is done I'd say.
        SceneManager.LoadScene("Game");
    }
    
}
