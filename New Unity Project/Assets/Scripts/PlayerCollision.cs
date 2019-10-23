using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PlayerCollision : MonoBehaviour
{
    public PlayerMovement movement;
    public GameObject deathParent;
    Animator deathAnimator;
    [SerializeField] private Animator Animator;

    public Text scoreText;

    public int score;

    public int actualScore;
    public bool BeenHit;

    public float thrust = 10000;

    public int timeLeft = 60;

    public int seeds;

    PowerupsManager mgr;

    private void Start()
    {
        score = 0;
        // particles = GetComponent<ParticleSystem>();
        mgr = FindObjectOfType<PowerupsManager>();
        deathAnimator = deathParent.GetComponent<Animator>();

    }



    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Obstacle")
        {
            scoreText.text = score + ("1");
            //particles.Play();
            BeenHit = true;
            actualScore = score + 1;
            Rigidbody rBody = other.gameObject.GetComponent<Rigidbody>();
            if (rBody)
            {
                rBody.AddForce(Vector3.forward + Vector3.up * 3000f);
                foreach (Collider col in other.gameObject.GetComponents<Collider>())
                {
                    col.enabled = false;
                }

                
            }

            Destroy(other.gameObject, 2);
        }

        if (other.gameObject.tag == "ObstacleBig" && seeds == 5)
        {
            Debug.Log("Udedsucker2");
            scoreText.text = score + ("10");
            //particles.Play();
            BeenHit = true;
            actualScore = score + 10;
            Rigidbody rBody = other.gameObject.GetComponent<Rigidbody>();
            if (rBody)
            {
                rBody.AddForce(Vector3.forward + Vector3.up * 3000f);
                foreach (Collider col in other.gameObject.GetComponents<Collider>())
                {
                    col.enabled = false;
                }


            }
            Destroy(other.gameObject, 2);
        }
        
        if(other.gameObject.tag == "ObstacleBig" && seeds < 5)
        {
            Debug.Log("Udedsucker");
            movement.enabled = false;

            deathAnimator.SetTrigger("HasFallen");
            FindObjectOfType<GameManager>().EndGame();
        }

    }



    private void OnTriggerExit(Collider collider)
    {
        if (collider.tag == "Obstacle")
        {
            BeenHit = false;
            Debug.Log("false");
        }
    }

    public void Update()
    {
        score = actualScore;
        scoreText.text = actualScore.ToString("0");

        seeds = mgr.SeedCount;
        // if (BeenHit == true){
        // actualScore = score +1;
        // }
    }


    

}

