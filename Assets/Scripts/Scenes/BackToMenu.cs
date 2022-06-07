using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class BackToMenu : MonoBehaviour
{
    public Button backToMenuButtton;

    public void Start()
    {
        backToMenuButtton.onClick.AddListener(BackToMyMenu);
    }

    public void BackToMyMenu()
    {
        //print("Starting Game");
        SceneManager.LoadScene(0);
    }

}
