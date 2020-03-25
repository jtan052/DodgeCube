using UnityEngine;

public class PlayerCollision : MonoBehaviour
{

    public PlayerMovement movement;
    
    void OnCollisionEnter (Collision collisionInfo) //Collision is a variable for the collison.....
    {
        //Debug.Log (collisionInfo.collider.name);

        if(collisionInfo.collider.tag == "Obstacle")
        {
            Debug.Log("You hit a red cube. You lose idiot.");
            movement.enabled = false;
            FindObjectOfType<GameManager>().EndGame();
        }
    }


}