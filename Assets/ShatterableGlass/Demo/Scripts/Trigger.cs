using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Glass will be shattered when Player steps in the trigger.
public class Trigger : MonoBehaviour
{

    // Target Glass
    public ShatterableGlass Glass;
    //public GameObject playerG;

    //void OnTriggerEnter(Collider Intruder)
    //{
    //    // Check if Intruder is Player:
    //    if (Intruder.tag == "Player")
    //    {
    //        // Do not attepmt to shatter glass, if Glass already Destroyed().
    //        if (Glass)
    //            Glass.Shatter(Vector2.zero, Glass.transform.forward);
    //        // Destroy() trigger itself.
    //        Destroy(gameObject);
    //    }
    //}
    public GameObject player;
    private void OnCollisionEnter(Collision collision)
    {
        // Check if Intruder is Player:
        if (collision.collider.tag == "Player")
        {
            player.SendMessage("PlayGlassBreak");
            //speaker.PlayOneShot(sound);
            // Do not attepmt to shatter glass, if Glass already Destroyed().
            if (Glass)
                Glass.Shatter(Vector2.zero, Glass.transform.forward);
        //    speaker.PlayOneShot(sound,0.5f);
            // Destroy() trigger itself.
           // playerG.SendMessage("PlayerDeath");
            Destroy(gameObject);
        }
    }
}
