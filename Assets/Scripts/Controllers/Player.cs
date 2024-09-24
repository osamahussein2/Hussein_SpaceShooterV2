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

    void Start()
    {
        acceleration = 0.0f;
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
            acceleration = maxSpeed / accelerationTime;

            direction += Vector3.left;
        }

        else if (Input.GetKey(KeyCode.RightArrow))
        {
            acceleration = maxSpeed / accelerationTime;

            direction += Vector3.right;
        }

        else if (Input.GetKey(KeyCode.DownArrow))
        {
            acceleration = maxSpeed / accelerationTime;

            direction += Vector3.down;
        }

        else if (Input.GetKey(KeyCode.UpArrow))
        {
            acceleration = maxSpeed / accelerationTime;

            direction += Vector3.up;
        }

        acceleration -= maxSpeed / decelerationTime * Time.deltaTime;

        if (acceleration <= 0.0f)
        {
            acceleration = 0.0f;
        }

        else if (acceleration > 0.0f)
        {
            direction.Normalize();

            playerVelocity += acceleration * Time.deltaTime * direction;
            transform.position += playerVelocity * Time.deltaTime;
        }
    }

}
