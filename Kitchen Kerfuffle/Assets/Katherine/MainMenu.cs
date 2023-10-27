using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    //main menu buttons

    public void LoadMainMenuScene()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void LoadCharacterScene()
    {
        SceneManager.LoadScene("CharacterSelection");
    }

    public void PlayGame()
    {
        SceneManager.LoadScene("Gameplay");
    }

    public void QuitGame()
    {
        Debug.Log("QUIT!!!!");
        Application.Quit();
    }

}
