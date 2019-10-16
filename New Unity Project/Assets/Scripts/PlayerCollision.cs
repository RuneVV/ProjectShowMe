using UnityEngine;
using UnityEngine.UI;

public class PlayerCollision : MonoBehaviour
{
    public PlayerMovement movement; //This is a reference top our PlayerMovement script
    public Text scoreText;

    public int score;

    public int actualScore;
    public bool BeenHit;



    private void Start()
    {
        score = 0;
    
    }

    // This function runs when we hit another object.
    // We get information about the collision and call it "collisionInfo".
    void OnTriggerEnter(Collider Collider)
    {
        // We check if the object we collide with has a tag called "obstacle".
        if (Collider.tag == "Obstacle")
        {
            //scoreText.text = score + ("1");
            BeenHit = true;
            actualScore = score + 1;
            Debug.Log("true");
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

