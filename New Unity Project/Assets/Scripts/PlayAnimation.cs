using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayAnimation : MonoBehaviour
{
    Animator ParentAnimator2;
    public GameObject parent;

    private void Awake()
    {
        ParentAnimator2 = parent.GetComponentInParent<Animator>();
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            ParentAnimator2.SetBool("PlayerComesClose", true);




        }
    }

    private void OnTriggerExit (Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            ParentAnimator2.SetBool("PlayerComesClose", false);




        }
    }
}
