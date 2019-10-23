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

    public int TimeLeft = 60;

    public float multiplier = 1.0f;

    public GameObject player;

    public float x = 0.7f;
    public float y = 0.7f;
    public float z = 0.7f;

    public bool countingDown = false;

    

    private void Awake()
    {
        Instance = this;
        //seedText = GameObject.Find("SeedText").GetComponent<Text>();
    }

    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1;
    }

    // Update is called once per frame
    void Update()
    {
       if ( SeedCount == maxSeeds)
        {
            

            
            countingDown = true;
            StartCoroutine(CountDown());
              
            
            
            

        }
        else
        {
            
        }
    }

    public void UpdateSeedCount(int _amount)
    {
        SeedCount += _amount;
        seedText.text = SeedCount.ToString();
    }

    IEnumerator CountDown()
    {
        while (true)
        {
            
            yield return new WaitForSeconds(6);
            TimeLeft--;

            Shrink();
            

        }
    }

    public void Shrink()
    {
        if (countingDown == true){
            Debug.Log("were shrinking");
            player.transform.localScale = new Vector3(x, y, z);
            SeedCount = 0;
            seedText.text = SeedCount.ToString();
            countingDown = false;

        }
        else {
            
        }
        
    }
}
