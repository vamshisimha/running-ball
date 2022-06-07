using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PickUpUI : MonoBehaviour
{
    public Text pickupText;

    public void Update()
    {
        int currentPickup = GameManager.pickups;
        pickupText.text = ":" + currentPickup.ToString();
       // yield return null;
    }
}
