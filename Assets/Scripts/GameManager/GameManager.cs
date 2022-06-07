
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public void Awake()
    {
        instance = this;
    }

    bool gameHasEnded;
    float restartDelay = 1f;
    public int deaths;
    public static int jumpCounts = 0;
    public static int maxJumps = 1;
    public static bool gameCanStart;

    public static int lives = 3;
    public static int startingLives = 3;
    public static int pickups = 0;

    public GameObject heart;
    public GameObject heart2;
    public GameObject heart3;

    void Start()
    {
        StartCoroutine("SetUI");
       // StartCoroutine("SlideText");
    }

    public void SetPickUp()
    {
        pickups++;
        //pickups += pickups;
    }

    public void LooseLives()
    {
        lives--;
    }

    public void EndGame() {

        gameHasEnded = false;
        if(gameHasEnded == false) {
            lives--;
            gameHasEnded = true;
            if (lives < 0)
            {
                print("GAME OVER");
                lives = startingLives;
            }
            Invoke("Restart", restartDelay);      
        }
    }

    public void Restart() {
        deaths += 1;
        
        gameCanStart = false;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
      
    }


    public void SetUI()
    {
        if (lives == 3)
        {
            heart.gameObject.SetActive(true);
            heart2.gameObject.SetActive(true);
            heart3.gameObject.SetActive(true);
        }
        if (lives == 2)
        {
            heart.gameObject.SetActive(true);
            heart2.gameObject.SetActive(true);
            heart3.gameObject.SetActive(false);
        }
        if (lives == 1)
        {
            heart.gameObject.SetActive(true);
            heart2.gameObject.SetActive(false);
            heart3.gameObject.SetActive(false);
        }
        if (lives == 0)
        {
            heart.gameObject.SetActive(false);
            heart2.gameObject.SetActive(false);
            heart3.gameObject.SetActive(false);
        }



    }
    

}
