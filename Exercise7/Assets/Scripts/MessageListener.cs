using System.Collections;
using System.Collections.Generic;
using System.Text;
using UnityEngine;
using UnityEngine.Events;

public class MessageListener : MonoBehaviour
{
    string text = "beep. ";
    // Start is called before the first frame update
    void Start()
    {
        // make this the message event listener
        MessageInvoker messageInvokerScript = GameObject.FindWithTag("MessageInvoker").GetComponent<MessageInvoker>();
        //messageInvokerScript.AddMessageEventListener(PrintMessage);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PrintMessage(string message)
    {
        StringBuilder stringBuilder = new StringBuilder();
        stringBuilder.Append(text);
        stringBuilder.Append(message);
        text = stringBuilder.ToString();

        Debug.Log(text);
    }
}
