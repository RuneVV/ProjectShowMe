using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PowerupsManager : MonoBehaviour
{
    public static PowerupsManager Instance;

    public int SeedCount;
    public Text seedText;
    public int maxSeeds = 5;

    private void Awake()
    {
        Instance = this;
        //seedText = GameObject.Find("SeedText").GetComponent<Text>();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       if ( SeedCount == maxSeeds)
        {
            //counter naar 0
            //power up telt af 10 - 0 , grote weer naar normaal.
            
        }
    }

    public void UpdateSeedCount(int _amount)
    {
        SeedCount += _amount;
        seedText.text = SeedCount.ToString();
    }
}
