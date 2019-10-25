using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Powerup : MonoBehaviour {
    public float multiplier = 1.4f;

    public int seedcount = 0;
    public int currentSeed;
    public int maxSeed = 5;

    public GameObject pickupEffect;

    public Text seedText;

    

    private void Start()
    {
        

    }
    public void Update()
    {
        
    }

    void OnTriggerEnter (Collider other)
    {
        if (other.CompareTag("Player") && seedcount < 5)
        {
            Pickup(other);
            
        }
    }
    void Pickup(Collider player)
    {

        Instantiate(pickupEffect, transform.position, transform.rotation);

        UpdateSeed(seedcount);
        Debug.Log(seedcount);
        
        PowerupsManager.Instance.UpdateSeedCount(1);

        player.transform.localScale *= multiplier;
                
        Destroy(gameObject);
    }

    public void UpdateSeed(int _amount)
    {
        seedcount += 1;
        
    }
}


