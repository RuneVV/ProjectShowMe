using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Powerup : MonoBehaviour {
    public float multiplier = 1.4f;

    public int seedcount = 0;
    public int currentSeed;
    public int maxSeed = 5;

    private GameObject pickupEffect;

    public Text seedText;

    

    private void Start()
    {
        

    }
    public void Update()
    {
        
    }

    void OnTriggerEnter (Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Pickup(other);
            
        }
    }
    void Pickup(Collider player)
    {

        //Instantiate(pickupEffect, transform.position, transform.rotation);
        

        PowerupsManager.Instance.UpdateSeedCount(1);

        player.transform.localScale *= multiplier;
                
        Destroy(gameObject);
    }
}
