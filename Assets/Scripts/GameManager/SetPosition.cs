using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetPosition : MonoBehaviour
{
    public float distance;
    public Transform targetObstacle;
    float x, z, y;
    public GameObject invincible;
    public GameObject jump;
    Vector3 pos;
    public int randomNum;

    public GameObject particleJump;
    public GameObject particleInvi;

    public ParticleSystem jump_par;
    public ParticleSystem invincible_par;

    void Start()
    {
        randomNum = Random.Range(1, 3);
        distance = 10.0f;
        JumpingOrInvincibleObj();
    }

    public void SetPositionRandomly() {
        x = Random.Range(-20, 20);
        y = 1.8f;
        z = Random.Range(500, 1000);
        pos = new Vector3(x, y, z);
        transform.position = pos;
    }

    public void JumpingOrInvincibleObj()
    {
        if(randomNum == 1)
        {
            jump.gameObject.GetComponent<Renderer>().enabled = false;
            jump.gameObject.GetComponent<Collider>().enabled = false;
            invincible.gameObject.GetComponent<Renderer>().enabled = true;
            invincible.gameObject.GetComponent<Collider>().enabled = true;
            //Destroy(particleJump);
            jump_par.Stop();
            invincible_par.Play();
            SetPositionRandomly();
        }
        else if(randomNum == 2)
        {
            invincible.gameObject.GetComponent<Renderer>().enabled = false;
            invincible.gameObject.GetComponent<Collider>().enabled = false;
            jump.gameObject.GetComponent<Renderer>().enabled = true;
            jump.gameObject.GetComponent<Collider>().enabled = true;
            // Destroy(particleInvi);
            invincible_par.Stop();
            jump_par.Play();
            SetPositionRandomly();
        }
 

    }


}
