using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RL_PlayerController : MonoBehaviour
{
    public float playerSpeed;
    private Rigidbody2D rb;
    private Vector2 playerDirection;

    // Start is called before the first frame update
    void Start()
    {
        // Gets the Rigigdbody 2d from the player
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        // The player will move between the up and down key arrows
        float directionY = Input.GetAxisRaw("Vertical");
        playerDirection = new Vector2(0, directionY).normalized;
    }

    void FixedUpdate()
    {
        // Determines the speed of the player's movement
        rb.velocity = new Vector2(0, playerDirection.y * playerSpeed);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        // If the player touches a banana, the banana will be destroyed
        if (other.gameObject.CompareTag("Banana"))
        {
            Destroy(other.gameObject);
        }
    }
}
