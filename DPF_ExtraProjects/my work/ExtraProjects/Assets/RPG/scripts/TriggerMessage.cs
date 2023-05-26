using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(TriggerDisplay))]
public class TriggerMessage : MonoBehaviour
{
    [Header("Text Input")]
    public string messageToShow = "default message";
    public float messageDuration = 3;

    private void OnTriggerEnter(Collider other)
    {
        
        //make sure tag is player
        if (other.tag == "Player")
        {
            GameObject.FindObjectOfType<UIController>().
            ShowMessage(messageToShow, messageDuration);
        }
    }
}
