using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
public class OnTriggerEvent : MonoBehaviour
{
    public UnityEvent onEnter;

    public void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("Trigger");

        //Triggers events for unlocking the door
        if (other.tag == "Player")
        {
            onEnter.Invoke();
            Debug.Log("Next Level");
        }
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        Debug.Log("Still Triggered");
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        Debug.Log("No longer Triggered");
    }
}
