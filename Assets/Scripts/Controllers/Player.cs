using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public List<Transform> asteroidTransforms;
    public Transform enemyTransform;
    public GameObject bombPrefab;
    public Transform bombsTransform;

    private Vector3 playerVelocity = new (0.01f, 0.01f);

    void Update()
    {
        PlayerMovement();
    }

    void PlayerMovement()
    {
        // Velocity movement for player keys
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.position -= new Vector3(playerVelocity.x, 0.0f);
        }

        else if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.position += new Vector3(playerVelocity.x, 0.0f);
        }

        else if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.position -= new Vector3(0.0f, playerVelocity.y);
        }

        else if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.position += new Vector3(0.0f, playerVelocity.y);
        }

        // Clamp the player from going past the screen limits manually
        if (transform.position.x >= 9.0f)
        {
            transform.position = new (9.0f, transform.position.y);
        }

        else if (transform.position.x <= -9.0f)
        {
            transform.position = new (-9.0f, transform.position.y);
        }

        if (transform.position.y >= 9.5f)
        {
            transform.position = new (transform.position.x, 9.5f);
        }

        else if (transform.position.y <= -9.5f)
        {
            transform.position = new (transform.position.x, -9.5f);
        }
    }

}
