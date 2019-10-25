using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoseCondition : MonoBehaviour
{
    public PlayerMovement movement;
    public GameObject parent;
    Animator parentAnimator;
    public GameObject deathEffect1;

    [SerializeField] private Animator animator;
    private void Awake()
    {
        parentAnimator = parent.GetComponent<Animator>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Lose1")
        {

           
            movement.forwardForce = 0;
            movement.sidewaysForce = 0;
             movement.enabled = false;

            animator.SetTrigger("HasFallen");
            Instantiate(deathEffect1, transform.position, transform.rotation);

            FindObjectOfType<GameManager>().EndGame();
            
            
        }
    }
}
