using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerUnbreakeable : MonoBehaviour
{
    // Target Glass
    public ShatterableGlass Glass;
    public GameObject playerG;

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

    private void OnCollisionEnter(Collision collision)
    {
        // Check if Intruder is Player:
        if (collision.collider.tag == "Player")
        {
            // Do not attepmt to shatter glass, if Glass already Destroyed().
            if (Glass)
                Glass.Shatter(Vector2.zero, Glass.transform.forward);
            // Destroy() trigger itself.
            playerG.SendMessage("PlayerDeath");
            Destroy(gameObject);
        }
    }
}
