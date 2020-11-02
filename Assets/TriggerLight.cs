using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerLight : MonoBehaviour
{
    public Light spotLight;
    public Color normalColour;
    public Color triggerColour;

    void OnTriggerEnter(Collider collider)
    {
        spotLight.color = triggerColour;
    }

    void OnTriggerExit(Collider collider)
    {
        spotLight.color = normalColour;
    }
}
