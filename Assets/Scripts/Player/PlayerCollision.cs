
using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PlayerCollision : MonoBehaviour
{

    public Text pickUPText;
    public PlayerMovement movement;
   // public GameObject playerMovement;
    public GameObject barrier;
    public GameObject obstacleDrop;

    public KeyCode powerOn;
    public float powerNum;

    public static bool isCollided;

    public AudioSource speaker;
    public AudioClip collideSound;



    void OnCollisionEnter(Collision collisionInfo)
    {
        if(collisionInfo.collider.tag == "Obstacle") {

            PlayerDeath();

        }
        
        if (collisionInfo.collider.tag == "ObstacleDrop") {
            PlayerDeath();
        }
        if(collisionInfo.collider.tag == "Ground")
        {
            GameManager.jumpCounts = GameManager.maxJumps;
        }


    }

    public void PlayerDeath()
    {
        movement.enabled = false;
        speaker.PlayOneShot(collideSound, 1);
        FindObjectOfType<GameManager>().EndGame();
    }
    public AudioClip glassBreakSound;
    public AudioClip pickUpSound;
    public AudioClip specialSound;
    public void PlayGlassBreak()
    {
        speaker.PlayOneShot(glassBreakSound, 0.2f);
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("SpecialPower")) {
            speaker.PlayOneShot(specialSound, 0.7f);
            InvokeRepeating("InvinciblePlayer", 0f,0.001f);
            StartCoroutine(StopPowerProcess());
        }

        //colliding with JumpingPower
        if (other.gameObject.CompareTag("JumpingPlayer"))
        {
            isCollided = true;
            speaker.PlayOneShot(specialSound,0.7f);
            InvokeRepeating("JumpingPlayerPower", 0f, 0.001f);
            StartCoroutine(StopJumpingProcess());
           // print("Colliding with special Power");
        }

        if (other.gameObject.CompareTag("PickUp"))
        {
            // print("PickUp collected");
            speaker.PlayOneShot(pickUpSound, 0.7f);
            GameManager.instance.SetPickUp();
          //  GameManager.pickUps = GameManager.pickUps++;
          //  pickUPText.text = "PickUps:" + GameManager.pickUps.ToString();
            other.gameObject.SetActive(false);
        }

    }

    public void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("SpecialPower"))
        {
            Timer.timerOn = true;
            other.gameObject.GetComponent<Renderer>().enabled = false;


        }
        if (other.gameObject.CompareTag("JumpingPlayer"))
        {
            Timer.timerOnJump = true;
            other.gameObject.GetComponent<Renderer>().enabled = false;
        }
    }



    IEnumerator StopPowerProcess() {
        yield return new WaitForSeconds(5.5f);
        Physics.IgnoreLayerCollision(9, 10,false);
        CancelInvoke();
    }

    IEnumerator StopJumpingProcess()
    {
        yield return new WaitForSeconds(10.5f);
         isCollided = false;
        CancelInvoke();
        print("JumpingPower");
    }

    public void InvinciblePlayer()
    {
        Physics.IgnoreLayerCollision(9, 10);

        transform.Rotate(0, 10, 0);
    }




    public void JumpingPlayerPower()
    {
        isCollided = true;
        transform.Rotate(0, 10, 0);

    }

}
