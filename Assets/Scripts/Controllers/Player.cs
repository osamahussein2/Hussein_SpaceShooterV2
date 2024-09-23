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

    void Start()
    {
        acceleration = maxSpeed / accelerationTime;
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
        }

        else if (Input.GetKey(KeyCode.RightArrow))
        {
            direction += Vector3.right;
        }

        else if (Input.GetKey(KeyCode.DownArrow))
        {
            direction += Vector3.down;
        }

        else if (Input.GetKey(KeyCode.UpArrow))
        {
            direction += Vector3.up;
        }

        direction.Normalize();

        playerVelocity += acceleration * Time.deltaTime * direction;
        transform.position += playerVelocity * Time.deltaTime;
    }

}
