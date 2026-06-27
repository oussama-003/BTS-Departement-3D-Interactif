using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Event;

public class LightSwitchController : MonoBehaviour
{
    [serializeField] private bool isLightOn;

    [SerializeField] private UnityEvent lightOnEvent;
    [SerializeField] private UnityEvent lightOffEvent;

    public void InteractSwitch()
    {
        if (!isLightOn)
        {
            isLightOn = true;
            lightOnEvent.Invoke();
        }
        else
        {
            isLightOn = false;
            lightOffEvent.Invoke();
        }
    }
}
