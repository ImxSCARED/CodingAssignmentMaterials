using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Teleporter3 : MonoBehaviour
{
   
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            SceneManager.LoadScene((int)SceneIndexes.Title_Screen);
            //show cursor
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
        }
    }
}
