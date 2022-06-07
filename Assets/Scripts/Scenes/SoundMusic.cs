using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SoundMusic : MonoBehaviour
{

    public AudioSource speaker;
    public AudioClip music;
    public AudioClip music1;
    public AudioClip music2;
    public AudioClip music3;
    public AudioClip music4;
    public AudioClip music5;
    public AudioClip music6;
    public AudioClip music7;
    public AudioClip music8;


    // Start is called before the first frame update
    public void Start()
    {
        speaker = GetComponent<AudioSource>();
        //speaker.Play();

        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByBuildIndex(0))
        {

            StartCoroutine("MusicLevel0");
        }

        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByBuildIndex(1))
        {

            StartCoroutine("MusicLevel1");
        }
        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByBuildIndex(2))
        {
            StartCoroutine("MusicLevel2");
           
        }
        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByBuildIndex(3))
        {
            StartCoroutine("MusicLevel3");
        
        }
        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByBuildIndex(4))
        {
            StartCoroutine("MusicLevel4");

        }
        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByBuildIndex(5))
        {
            StartCoroutine("MusicLevel5");

        }
        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByBuildIndex(6))
        {
            StartCoroutine("MusicLevel6");

        }
        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByBuildIndex(7))
        {
            StartCoroutine("MusicLevel7");

        }
        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByBuildIndex(8))
        {
            StartCoroutine("MusicLevel8");

        }

    }
    public IEnumerator MusicLevel0()
    {

        yield return new WaitForSeconds(0.2f);
        speaker.PlayOneShot(music, 1);

    }

    public IEnumerator MusicLevel1()
    {
 
        yield return new WaitForSeconds(3);
        speaker.PlayOneShot(music1, 1);

    }
   public IEnumerator MusicLevel2()
    {

        yield return new WaitForSeconds(3);
        speaker.PlayOneShot(music2, 1);

    }
   public IEnumerator MusicLevel3()
    {

        yield return new WaitForSeconds(3);
        speaker.PlayOneShot(music3, 1);

    }
    public IEnumerator MusicLevel4()
    {

        yield return new WaitForSeconds(3);
        speaker.PlayOneShot(music4, 1);

    }
    public IEnumerator MusicLevel5()
    {

        yield return new WaitForSeconds(3);
        speaker.PlayOneShot(music5, 1);

    }
    public IEnumerator MusicLevel6()
    {

        yield return new WaitForSeconds(3);
        speaker.PlayOneShot(music6, 1);

    }

    public IEnumerator MusicLevel7()
    {

        yield return new WaitForSeconds(3);
        speaker.PlayOneShot(music7, 1);

    }

    public IEnumerator MusicLevel8()
    {

        yield return new WaitForSeconds(0.2f);
        speaker.PlayOneShot(music8, 1);

    }
}
