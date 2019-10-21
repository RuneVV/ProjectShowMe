using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerVfx : MonoBehaviour
{
    public AudioClip AnimalSound;
    public AudioSource audioSource;
    
    ParticleSystem DustParticles;
    private void Awake()
    {
        DustParticles = GetComponentInChildren<ParticleSystem>();
        DustParticles.Stop();

        audioSource = GetComponent<AudioSource>();
        audioSource.clip = AnimalSound;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            
            audioSource.Play();

            DustParticles.Play();
            

            
        }
    }

   
}
