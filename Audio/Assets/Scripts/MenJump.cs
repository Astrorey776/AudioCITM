using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenJump : MonoBehaviour
{

    public AudioClip fall;


   void PlayMenJump()
    {

        AudioSource audioSource = GetComponent<AudioSource>();
        audioSource.volume = Random.Range(0.9f, 1.0f);
        audioSource.pitch = Random.Range(0.9f, 1.1f);

        
        audioSource.PlayOneShot(fall);
     
    }



}
