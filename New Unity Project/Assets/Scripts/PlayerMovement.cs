using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // This is a reference to the Rigidbody component called "rb"
    public Rigidbody rb;

    
    public float forwardForce = 500f;
    public float sidewaysForce = 100f;
    public float increaseSpeed = 300f;
    public float maxSpeed = 8000f;
    public float currentspeed;

    public bool go;



    private float minX = -3;
    private float maxX = 3;

   

    private void Start()
    {
        forwardForce = 2000f;
    }

    private void Update()
    {
        Vector3 clampedPosition = transform.position;
        clampedPosition.x = Mathf.Clamp(clampedPosition.x, -7.0f, 7.0f);
        transform.position = clampedPosition;
                        
    }

    // Update is called once per frame
    // Use FixedUpdate instead of Update when using physics (Makes it look smoother when things collide)
    void FixedUpdate() 
    {
       if(forwardForce <= maxSpeed)
        {
            go = true;
        }
        else
        {
            go = false;
        }

       if (go == true)
        {
            currentspeed = forwardForce += increaseSpeed * Time.deltaTime;
        }
        else
        {
            StopCounting();
        }
       

        // Add a forward Force
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);

        if (Input.GetKey("d"))
        {
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (Input.GetKey("a"))
        {
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (rb.position.y < -1f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }
        
    }

   
    public void StopCounting()
    {
        forwardForce = maxSpeed;
    }
}
