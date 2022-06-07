using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Text_UI : MonoBehaviour
{
    public Text slideText;
    public Text avoidText;
    public Text pickUpText;
    // Start is called before the first frame update
    void Start()
    {
        avoidText.text = "";
        pickUpText.text = "";
        StartCoroutine("Slide");
        StartCoroutine("Avoid");
        StartCoroutine("Pick");
    }

    // Update is called once per frame
    IEnumerator Slide()
    {
        slideText.text = "";
        yield return new WaitForSeconds(3);
        slideText.text = "Slide Finger";
        yield return new WaitForSeconds(2);
        slideText.text = "";
    }
    IEnumerator Avoid()
    {
        
        yield return new WaitForSeconds(6);
        slideText.text = "Avoid Red Mirrors";
        yield return new WaitForSeconds(2);
        slideText.text = "";
    }
    IEnumerator Pick()
    {
        
        yield return new WaitForSeconds(9);
        slideText.text = "Pick Up Powers";
        yield return new WaitForSeconds(2);
        slideText.text = "";
    }
}
