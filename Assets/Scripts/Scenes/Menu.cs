using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Menu : MonoBehaviour
{
    //public Button playButton;
    //public Button quitButton;

    public void Update()
    {

        //playButton.onClick.AddListener(StartGame);
        //quitButton.onClick.AddListener(QuitGame);
    }

    public void StartGame()
    {
        ////print("Starting Game");
        SceneManager.LoadScene(1);
    }
    public void QuitGame()
    {
        //print("Quitting Application");
        Application.Quit();
    }
}
