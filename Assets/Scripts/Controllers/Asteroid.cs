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
            // Set the random point vector to randomize the points for the asteroid to go to
            randomPoint = new(Random.Range(-9, 9), Random.Range(-9, 9));

            // Set the arrival distance to 0 because we haven't arrived at the destination yet
            arrivalDistance = 0.0f;

            // Because the asteroid has a random point to move to, we can set this to true
            hasDecidedToMove = true;
        }

        // If the asteroid really knows to move to the random point assigned to them
        else if (hasDecidedToMove == true)
        {
            // Move the asteroids to their random points at their move speed value
            transform.position += (randomPoint - transform.position) * moveSpeed * Time.deltaTime;

            // Increment the arrival distance to know the asteroid will be arriving at the random point
            arrivalDistance += (maxFloatDistance - arrivalDistance) * moveSpeed * Time.deltaTime;

            // If the arrival distance is greater than the max float distance
            if (arrivalDistance >= maxFloatDistance - 0.001f)
            {
                // Constrain the arrival distance to equal to the max distance so that it can't exceed the random point
                arrivalDistance = maxFloatDistance;

                // Set this to false so the asteroid can move to a new random point
                hasDecidedToMove = false;
            }
        }
    }
}
