using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinMenu : MonoBehaviour
{
    [Header("Parametrs")]
    [SerializeField] public GameObject winMenuUI;
    public void LoadMenu()
    {
        SceneManager.LoadScene("MainMenu");
        Time.timeScale = 1f;
        Debug.Log("Exit to MainMenu");
    }
    public void Exit()
    {
        Application.Quit();
        Debug.Log("Exit pressed");
    }
}
