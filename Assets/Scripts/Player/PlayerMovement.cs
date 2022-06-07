using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{
    Transform lookAtCube;
    public Rigidbody rb;
    public float forwardForce = 2f;
    public float sideWaysForce = 200f;
    bool canJump;
    static public bool isInvincible;

    float timeCounter = 0f;
    float invincebleTime = 5f;
    public float distanceFromTarget;
    float dropForce = 2;


    public Transform[] targets;
    public Rigidbody[] rbObstacles;

    public Animator anim;
    float mouseMovement;
    //public GameObject[] dropObjects;
   

    public void Start()
    {
        Cursor.visible = false;
       // print(GameManager.instance.lives);
        // lookAtCube = transform.Find("lookAtCube");
        isInvincible = false;
        PlayerCollision.isCollided = false;
        distanceFromTarget = 150.0f;
//        print("Num deaths: " + GameManager.deaths);
        GameManager.jumpCounts = GameManager.maxJumps;

        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByBuildIndex(3))
        {

            foreach (Rigidbody rigiObstacle in rbObstacles)
            {
                rigiObstacle.useGravity = false;
            }

        }

        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByBuildIndex(4))
        {

          foreach(Rigidbody rigiObstacle in rbObstacles)
            {
                rigiObstacle.useGravity = false;
            }

        }

        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByBuildIndex(5))
        {

            foreach (Rigidbody rigiObstacle in rbObstacles)
            {
                rigiObstacle.useGravity = false;
            }

        }

        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByBuildIndex(6))
        {

            foreach (Rigidbody rigiObstacle in rbObstacles)
            {
                rigiObstacle.useGravity = false;
            }

        }

        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByBuildIndex(7))
        {

            foreach (Rigidbody rigiObstacle in rbObstacles)
            {
                rigiObstacle.useGravity = false;
            }

        }
    }

    public void FixedUpdate()
    {
      //  mouseMovement = Input.GetAxis("Mouse X");
      canJump = Input.GetMouseButtonDown(0);


        // Dampen towards the target rotation

        if (GameManager.gameCanStart)
         {

            rb.AddForce(0, 0, forwardForce * Time.deltaTime);

        if (Input.GetAxis("Mouse X") < 0)
         {
                rb.AddForce(-sideWaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
                //transform.Rotate(new Vector3(0, -0.7f, 0));

            }
        if (Input.GetAxis("Mouse X") > 0)
         {
                rb.AddForce(sideWaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
                transform.Rotate(new Vector3(0, 0.7f, 0));
            }

        if (canJump && PlayerCollision.isCollided == true)
        {

            if(GameManager.jumpCounts > 0)
            {
                Jump();

            }

        }

        if(rb.position.y < -1) {

            FindObjectOfType<GameManager>().EndGame();
        }


        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByBuildIndex(3)) {


            for(int i = 0; i < targets.Length; i++)
                {
                    if (Vector3.Distance(transform.position, targets[i].position) <= distanceFromTarget)
                    {
                        for(int a = 0; a < rbObstacles.Length; a++)
                        {
                            rbObstacles[i].AddForce(new Vector3(0,-dropForce));
                        }
                    }
                }

        }

            if (SceneManager.GetActiveScene() == SceneManager.GetSceneByBuildIndex(4))
            {


                for (int i = 0; i < targets.Length; i++)
                {
                    if (Vector3.Distance(transform.position, targets[i].position) <= distanceFromTarget)
                    {
                        for (int a = 0; a < rbObstacles.Length; a++)
                        {
                            rbObstacles[i].AddForce(new Vector3(0, -dropForce));
                        }
                    }
                }

            }

            if (SceneManager.GetActiveScene() == SceneManager.GetSceneByBuildIndex(5))
            {


                for (int i = 0; i < targets.Length; i++)
                {
                    if (Vector3.Distance(transform.position, targets[i].position) <= distanceFromTarget)
                    {
                        for (int a = 0; a < rbObstacles.Length; a++)
                        {
                            rbObstacles[i].AddForce(new Vector3(0, -dropForce));
                        }
                    }
                }

            }

            if (SceneManager.GetActiveScene() == SceneManager.GetSceneByBuildIndex(6))
            {


                for (int i = 0; i < targets.Length; i++)
                {
                    if (Vector3.Distance(transform.position, targets[i].position) <= distanceFromTarget)
                    {
                        for (int a = 0; a < rbObstacles.Length; a++)
                        {
                            rbObstacles[i].AddForce(new Vector3(0, -dropForce));
                        }
                    }
                }

            }

            if (SceneManager.GetActiveScene() == SceneManager.GetSceneByBuildIndex(7))
            {


                for (int i = 0; i < targets.Length; i++)
                {
                    if (Vector3.Distance(transform.position, targets[i].position) <= distanceFromTarget)
                    {
                        for (int a = 0; a < rbObstacles.Length; a++)
                        {
                            rbObstacles[i].AddForce(new Vector3(0, -dropForce));
                        }
                    }
                }

            }
        }

    }

    public void Jump()
    {
        GameManager.jumpCounts -= 1;
        //Debug.Log("Pressing space to jump");
        rb.AddForce(new Vector3(0, 15, 0), ForceMode.Impulse);


    }

    public void FreezeMovement()
    {
        //Stop Moving/Translating
        rb.velocity = Vector3.zero;

        //Stop rotating
        rb.angularVelocity = Vector3.zero;
    }

    public void InvinciblePlayer()
    {
        if (timeCounter < invincebleTime)
        {
            transform.Rotate(0, 0, 10);
            gameObject.SetActive(false);

            timeCounter += Time.deltaTime;
        }



    }

}
