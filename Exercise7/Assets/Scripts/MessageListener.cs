using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MessageListener : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // make this the message event listener
        MessageInvoker messageInvoker = Camera.main.GetComponent<MessageInvoker>();
        messageInvoker.AddNoArgumentListener(PrintMessage);
    }

    void PrintMessage()
    {
        Debug.Log("beep");
    }
}
