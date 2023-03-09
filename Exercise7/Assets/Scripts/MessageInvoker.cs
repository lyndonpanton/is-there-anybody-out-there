using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class MessageInvoker : MonoBehaviour
{
    Timer timer;
    MessageEvent messageEvent;

    void Awake()
    {
        messageEvent = new MessageEvent();
    }

    // Start is called before the first frame update
    void Start()
    {
        timer = gameObject.AddComponent<Timer>();
        timer.Duration = 1;
        timer.Run();
    }

    // Update is called once per frame
    void Update()
    {
        if (timer.Finished)
        {
            messageEvent.Invoke();
            timer.Run();
        }
    }


    public void AddNoArgumentListener(UnityAction listener)
    {
        messageEvent.AddListener(listener);
    }
}
