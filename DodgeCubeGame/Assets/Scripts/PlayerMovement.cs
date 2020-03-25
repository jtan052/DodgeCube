using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;

    public float forwardForce = 2000f;
    public float sidewaysForce = 500f;
    // Start is called before the first frame update
    //void Start() //this is called when the game begins.
    //{
        //Debug.Log("Hello, World!"); //Debug.Log("") for messages to console. like cout.
        //rb.useGravity = false; //turns off gravity for Rigidbody
        //rb.AddForce(0, 200, 500); //adds a force in x,y,z directions.
    //}

    // Update is called once per frame. Use FixedUpdate when working with Unity Physics engine
    void FixedUpdate()
    {
        //add a forward force
        //rb.AddForce(0, 0, forwardForce * Time.deltaTime); //amount of seconds since computer drew the last frame. 10fps = .1 20fps = .05

        //.useGravity = false;

        if (Input.GetKey("d"))
        {
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (Input.GetKey("a"))
        {
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (Input.GetKey("s"))
        {
            rb.AddForce(0, 0, -forwardForce * Time.deltaTime, ForceMode.VelocityChange);
        }

        if (Input.GetKey("w"))
        {
            rb.AddForce(0, 0, forwardForce * Time.deltaTime, ForceMode.VelocityChange);
        }

        if(rb.position.y < 0)
        {
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
