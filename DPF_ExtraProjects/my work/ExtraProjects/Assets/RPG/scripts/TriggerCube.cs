using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerCube : MonoBehaviour
{

     void OnTriggerEnter( Collider other)
    {
        if (other.tag == "Player")
        {
            Debug.Log("Happy to see you!");
        }
    }
     void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            Debug.Log("Sorry to see you go");
        }
    }
     void OnTriggerStay(Collider other)
    {
        if (other.tag == "Player")
        {
            Debug.Log("I wish you would LEAVE!");
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
