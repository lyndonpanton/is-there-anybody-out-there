using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class MessageInvoker : MonoBehaviour
{
    Timer timer;

    MessageEvent messageEvent = new MessageEvent();
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (timer.Finished)
        {
            timer.Duration = 1;
            timer.Run();
            //AddNoArguementListener(messageEvent);
        }
    }

    void Awake()
    {
        timer = new Timer();
        timer.Duration = 1;
        timer.Run();
    }



    public void AddNoArguementListener(UnityAction listener)
    {
        //messageEvent.AddListener(listener);
    }
}
