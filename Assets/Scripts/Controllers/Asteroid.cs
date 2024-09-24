using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Asteroid : MonoBehaviour
{
    public float moveSpeed;
    public float arrivalDistance;
    public float maxFloatDistance;

    public bool hasDecidedToMove;

    public Vector3 randomPoint;

    // Start is called before the first frame update
    void Start()
    {
        hasDecidedToMove = false;
    }

    // Update is called once per frame
    void Update()
    {
        AsteroidMovement();
    }

    void AsteroidMovement()
    {
        // If the asteroid doesn't know which point to go to
        if (hasDecidedToMove == false)
        {
            float asteroidMaxFloatDistancePointX = transform.position.x + maxFloatDistance;
            float asteroidMaxFloatDistancePointY = transform.position.y + maxFloatDistance;

            // Set the random point vector to randomize the points for the asteroid to go to using max distance value
            randomPoint = new(Random.Range(-asteroidMaxFloatDistancePointX, asteroidMaxFloatDistancePointX), 
                Random.Range(-asteroidMaxFloatDistancePointY, asteroidMaxFloatDistancePointY));

            // Because the asteroid has a random point to move to, we can set this to true
            hasDecidedToMove = true;
        }

        // If the asteroid really knows to move to the random point assigned to them
        else if (hasDecidedToMove == true)
        {
            // Move the asteroids to their random points at their move speed value
            transform.position += (randomPoint - transform.position) * moveSpeed * Time.deltaTime;

            // If the distance between the asteroid and the random point is equal to the arrival distance
            if (Vector2.Distance(transform.position, randomPoint) <= arrivalDistance)
            {
                // Set this to false so the asteroid can move to a new random point
                hasDecidedToMove = false;
            }
        }
    }
}
