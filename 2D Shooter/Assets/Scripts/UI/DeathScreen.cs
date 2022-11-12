using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathScreen : MonoBehaviour
{
    [Header("Parametrs")]
    [SerializeField] private GameObject deathScreenUI;
    private void Retry()
    {
        Debug.Log("Retry game");
        SceneManager.LoadScene("Game");
    }
    private void LoadMenu()
    {
        Debug.Log("Exit to MainMenu");
        SceneManager.LoadScene("MainMenu");
        Time.timeScale = 1f;
    }
    private void Exit()
    {
        Debug.Log("Exit pressed");
        Application.Quit();
    }
}
