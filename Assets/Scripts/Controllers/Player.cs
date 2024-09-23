using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public List<Transform> asteroidTransforms;
    public Transform enemyTransform;
    public GameObject bombPrefab;
    public Transform bombsTransform;

    private Vector3 playerVelocity;

    public float accelerationTime = 3.0f;
    public float maxSpeed = 5.0f;

    private float acceleration;

    public float decelerationTime = 3.0f;
    private float deceleration;

    void Start()
    {
        acceleration = maxSpeed / accelerationTime;

        deceleration = -maxSpeed / decelerationTime;
    }

    void Update()
    {
        // Task 1
        PlayerMovement();
    }

    // Task 1
    void PlayerMovement()
    {
        Vector3 direction = Vector3.zero;

        // Velocity movement for player keys
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            direction += Vector3.left;

            acceleration = maxSpeed / accelerationTime;
        }

        else if (Input.GetKey(KeyCode.RightArrow))
        {
            direction += Vector3.right;

            acceleration = maxSpeed / accelerationTime;
        }

        else if (Input.GetKey(KeyCode.DownArrow))
        {
            direction += Vector3.down;

            acceleration = maxSpeed / accelerationTime;
        }

        else if (Input.GetKey(KeyCode.UpArrow))
        {
            direction += Vector3.up;

            acceleration = maxSpeed / accelerationTime;
        }

        direction.Normalize();

        if (direction == Vector3.zero)
        {
            acceleration -= maxSpeed / decelerationTime;

            if (acceleration <= 0.0f)
            {
                acceleration = 0.0f;
            }
        }

        playerVelocity += acceleration * Time.deltaTime * direction;
        transform.position += playerVelocity * Time.deltaTime;
    }

}
