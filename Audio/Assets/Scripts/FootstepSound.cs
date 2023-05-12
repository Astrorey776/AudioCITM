using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FootstepSound : MonoBehaviour
{
    public AudioClip footstepsOnGrass;
    public AudioClip footstepsOnTile;

    public string material;

    void PlayFootstepSound()
    {

        AudioSource audioSource = GetComponent<AudioSource>();
        audioSource.volume = Random.Range(0.9f,1.0f);
        audioSource.pitch = Random.Range(0.9f,1.1f);

        switch(material)
        {
            case "Grass":
                    audioSource.PlayOneShot(footstepsOnGrass);
                break;

            case "Tile":
                    audioSource.PlayOneShot(footstepsOnTile);
                break;

            default:
                break;
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        switch(collision.gameObject.tag)
        {
            case "Grass":
            case "Tile":
                material = collision.gameObject.tag;
                break;

            default:
                break;
        }
    }
}
