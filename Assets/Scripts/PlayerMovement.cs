
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;
    public float forwardForce = 500f;
    public float sidewaysForce = 500f;
    private bool moveLeft = false;
    private bool moveRight = false;

    // Start is called before the first frame update
    //void Start()
    //{
    //    rb.useGravity = false;
    //    rb.AddForce(0, 0, 200);

    //}

    private void Update()
    {
        if (Input.GetKey("w"))
        {
            forwardForce = 100f + forwardForce;
        }
        if (Input.GetKey("s"))
        {
            forwardForce = Mathf.Max(forwardForce - 100f, 0);
        }
        if (Input.GetKeyDown("a"))
        {
            moveLeft = true;
        }
        if (Input.GetKeyUp("a"))
        {
            moveLeft = false;
        }
        if (Input.GetKeyDown("d"))
        {
            moveRight = true;
        }
        if (Input.GetKeyUp("d"))
        {
            moveRight = false;
        }

    }
    void FixedUpdate()
    {

        rb.AddForce(0, 0, forwardForce * Time.fixedDeltaTime);

        if (moveRight)
        {
            rb.AddForce(sidewaysForce * Time.fixedDeltaTime, 0, 0, ForceMode.VelocityChange);
        }
        else
        {
            rb.AddForce(0, 0, 0);
        }

        if (moveLeft)
        {
            rb.AddForce(-sidewaysForce * Time.fixedDeltaTime, 0, 0, ForceMode.VelocityChange);
        }
        else
        {
            rb.AddForce(0, 0, 0);
        }

        if (rb.position.y < -1f)
        {            
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
