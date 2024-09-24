using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Enemy : MonoBehaviour
{
    public Transform player;

    private float speed;

    private void Update()
    {
        EnemyMovement();
    }

    void EnemyMovement()
    {
        // Stop the enemy from moving if it's distance to the player is equal to 0
        if (Vector2.Distance(transform.position, player.position) <= 0.0f)
        {
            // Set the enemy's speed to 0 to stop moving
            speed = 0.0f;

            //transform.position = transform.position; // This is another way I could stop the enemy from moving
        }

        /* I could also write an else statement, but I prefer the else if statement for more clarification to what I
         actually want to achieve */

        /* Else if the distance between the enemy and player is greater than 0, set the enemy's speed to be greater 
        than 0 */
        else if (Vector2.Distance(transform.position, player.position) > 0.0f)
        {
            // Randomize the enemy's speed per frame
            speed = Random.Range(0.01f, 1.0f);
        }

        // I prefer to set the equation for the enemy to move towards the player at randomized speed per frame
        transform.position += (player.position - transform.position) * speed * Time.deltaTime;

        /* This is by far, the easiest way to make an enemy move towards the player
        transform.position = Vector3.MoveTowards(transform.position, player.position, 5.0f * Time.deltaTime); */
    }

}
