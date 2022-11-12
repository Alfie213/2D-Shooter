using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuControls : MonoBehaviour
{
    public void PlayPressed()
    {
        Debug.Log("Play pressed");
        SceneManager.LoadScene("Game");
    }
    public void ExitPressed()
    {
        Debug.Log("Exit pressed");
        Application.Quit();
    }
}
