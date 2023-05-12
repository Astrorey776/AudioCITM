using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class CamaraAnecoica : MonoBehaviour
{
    public AudioMixerSnapshot anecoicCamera;
    public AudioMixerSnapshot indoorSnapshot;

    public float transitionTime = 0.25f;

    void OnTriggerEnter(Collider collider)
    {
        anecoicCamera.TransitionTo(transitionTime);
        
    }

    void OnTriggerExit(Collider collider)
    {
        indoorSnapshot.TransitionTo(transitionTime);
    
    }
}
