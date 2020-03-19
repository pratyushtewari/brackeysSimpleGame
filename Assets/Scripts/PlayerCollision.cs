
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public PlayerMovement movement;

    private void OnCollisionEnter(Collision collision)
    {        
        Debug.Log("I hit " + collision.collider.tag);
        if (collision.collider.tag == "Obstacle")
        {
        //movement.enabled = false;
        }
    }

}
