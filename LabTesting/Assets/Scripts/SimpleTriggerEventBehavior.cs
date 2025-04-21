using UnityEngine;
using UnityEngine.Events;



public class SimpleTriggerEventBehavior : MonoBehaviour
{
    public UnityEvent triggerEvent;
    Animator animator;


    private void OnTriggerEnter(Collider other)
    {
        // trigger the event and test with a debug message
        triggerEvent.Invoke();
    }
}
