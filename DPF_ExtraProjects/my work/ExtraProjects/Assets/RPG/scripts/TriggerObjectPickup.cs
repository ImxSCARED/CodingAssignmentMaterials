using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(TriggerDisplay))]
public class TriggerObjectPickup : MonoBehaviour
{
    public string objectName = "This Thing";

     void OnTriggerEnter(Collider other)
    {
        
        if (other.tag == "Player")
        {
            GameObject.FindObjectOfType<UIController>().ShowMessage("You have picked up a " + objectName, 2);
            GameObject.FindObjectOfType<InventoryController>().AddItem(objectName);
            gameObject.SetActive(false);
        }
    }
}
