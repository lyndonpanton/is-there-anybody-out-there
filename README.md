# is-there-anybody-out-there
Exercise 7 of the "Intermediate Object-Oriented Programming for Unity Games" course of the "C# Programming for Unity Game Development" Specialization by the University of Colorado via Coursera

## Description

Problem 1 – Add events

Create a new Unity project named Exercise7 and rename SampleScene as scene0.

Create a script named MessageEvent for an event that inherits from the UnityEventUnityEvent that doesn't have any arguments. The script will be printing messages to the Console window. Remember, UnityEventUnityEvent is in the UnityEngine.EventsUnityEngine.Events namespace.

Problem 2 – Implement event handling

Create an Invoker script. Copy one of the Timer scripts we've been using into the project. Declare fields for a timer and a no argument event object. Add an AwakeAwake method that creates an instance of the event object in your new field. Add a public AddNoArgumentListenerAddNoArgumentListener method that adds a no argument UnityAction delegate as a listener; remember, UnityActionUnityAction is in the UnityEngine.EventsUnityEngine.Events namespace. Add code to the StartStart method to add a Timer component, set its duration to 1 second, and run the timer. Add code to the UpdateUpdate method to invoke the event and run the timer again after it's finished. 

In the Unity editor, attach the Invoker script to the main camera.

Create a Listener script. Add a no argument method that prints a message of your choice. In the StartStart method, add code to get access to the Invoker class (by getting the Invoker component from the main camera) and add your no argument method as a listener.

In the Unity editor, attach the Listener script to the main camera.

Run the game. The message should be printed in the Console window every second.

## Getting Started

n/a

### Dependencies

* Windows 10
* Microsoft Visual Studio
* .NET
* Unity

### Installing

* Download link: [Github Repository](https://github.com/lyndonpanton/is-there-anybody-out-there)

### Executing program

n/a

## Help

n/a

## Authors

Lyndon Mykal Panton
[lyndonpanton](https://github.com/lyndonpanton/)

## Version History

* 0.1
    * Initial Release

## License

n/a

## Acknowledgments

Problem provided by the _University of Colorado_ and _Coursera_
