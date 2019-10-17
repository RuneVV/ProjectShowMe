using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YeetScript : MonoBehaviour
{
    public float thrust = 100;
    public Rigidbody rb;

    void OnCollissionEnter(Collider Collider)
    {
       
        if (Collider.tag == "Player")
        {
            Debug.Log("hasbeenhit");
            rb.AddForce(transform.forward * thrust);
        }
    }
}
