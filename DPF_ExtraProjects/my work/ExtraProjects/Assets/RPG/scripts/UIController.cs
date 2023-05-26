using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

public class UIController : MonoBehaviour
{
    public Text messageText;
    public GameObject messagePanel;
    private float displayTimer;
    private float displayLength;
    private bool isShowingMessage = false;

  public void ShowMessage(string message, float duration = 3)
    {
        //set the message
        messagePanel.SetActive(true);
        messageText.text = message;
        isShowingMessage = true;
        displayLength = duration;
        displayTimer = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        if (isShowingMessage)
        {
            //how long has passed?
            if (Time.time - displayTimer >displayLength)
            {
                //deactivate panel
                messagePanel.SetActive(false);
                isShowingMessage = false;
            }
        }
    }
}
