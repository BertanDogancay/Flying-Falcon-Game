using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public string firstScene;

    public void startGame()
    {
        SceneManager.LoadScene(firstScene);
    }

    public void openOptions()
    {

    }

    public void closeOptions()
    {

    }

    public void goToMainMenu()
    {
        SceneManager.LoadScene(firstScene);
    }

    public void quitGame()
    {
        Application.Quit();
        Debug.Log("Quitting the game...");
    }
}
