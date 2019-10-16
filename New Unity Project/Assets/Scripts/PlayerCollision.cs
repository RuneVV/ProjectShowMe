using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public PlayerMovement movement; //This is a reference top our PlayerMovement script

    // This function runs when we hit another object.
    // We get information about the collision and call it "collisionInfo".
    void OnCollisionEnter(Collision collisionInfo)
    {
        // We check if the object we collide with has a tag called "obstacle".
        if (collisionInfo.collider.tag == "Obstacle")
        {
            movement.enabled = false; //This disables the players movement
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
