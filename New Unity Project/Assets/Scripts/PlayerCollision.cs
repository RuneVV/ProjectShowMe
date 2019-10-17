using UnityEngine;
using UnityEngine.UI;

public class PlayerCollision : MonoBehaviour
{
    public PlayerMovement movement; //This is a reference top our PlayerMovement script
    public Text scoreText;

    public int score;

    public int actualScore;
    public bool BeenHit;

    public float thrust = 10000;
    //public Rigidbody rb;



    private void Start()
    {
        score = 0;
    
    }



    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Obstacle")
        {
            scoreText.text = score + ("1");
            BeenHit = true;
            actualScore = score + 1;
            Rigidbody rBody = other.gameObject.GetComponent<Rigidbody>();
            if(rBody)
            {
                rBody.AddForce(Vector3.up * 1000f);
                foreach(Collider col in other.gameObject.GetComponents<Collider>())
                {
                    col.enabled = false;
                }
            }
        }
    }

  

    private void OnTriggerExit(Collider collider)
    {
        if(collider.tag == "Obstacle")
        {
            BeenHit = false;
            Debug.Log("false");
        }
    }

    public void Update()
    {
        score = actualScore;
        scoreText.text = actualScore.ToString("0"); 

       // if (BeenHit == true){
           // actualScore = score +1;
       // }
    }


}

