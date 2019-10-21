using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoseCondition : MonoBehaviour
{
    public PlayerMovement movement;
    public GameObject parent;
    Animator parentAnimator;

    [SerializeField] private Animator animator;
    private void Awake()
    {
        parentAnimator = parent.GetComponent<Animator>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Lose1")
        {
            movement.enabled = false;

            animator.SetTrigger("HasFallen");

            FindObjectOfType<GameManager>().EndGame();
            
            
        }
    }
}
