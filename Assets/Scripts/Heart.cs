using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Heart : MonoBehaviour
{
    //public GameManager heart;
    //public GameManager heart2;
    //public GameManager heart3;
    //// Start is called before the first frame update
    //void Start()
    //{
    //    StartCoroutine("SetUI");
    //}

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, -4, 0);
    }

    //public void SetUI()
    //{
    //    if(GameManager.lives == 3) {
    //        heart.gameObject.SetActive(true);
    //        heart2.gameObject.SetActive(true);
    //        heart3.gameObject.SetActive(true);
    //    }
    //    if (GameManager.lives == 2)
    //    {
    //        heart.gameObject.SetActive(true);
    //        heart2.gameObject.SetActive(true);
    //        heart3.gameObject.SetActive(false);
    //    }
    //    if (GameManager.lives == 1)
    //    {
    //        heart.gameObject.SetActive(false);
    //        heart2.gameObject.SetActive(false);
    //        heart3.gameObject.SetActive(false);
    //    }
    //    if (GameManager.lives == 0)
    //    {
    //        heart.gameObject.SetActive(false);
    //        heart2.gameObject.SetActive(false);
    //        heart3.gameObject.SetActive(false);
    //    }

    //}
}
