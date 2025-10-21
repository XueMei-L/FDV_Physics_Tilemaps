using UnityEngine;

public class PlayerController_Physics : MonoBehaviour
{
    private SpriteRenderer spriteRenderer;
    private Animator animator;
    public float speed = 10.0f;

    void Start()
    {
        // Get the SpriteRenderer and Animator components
        spriteRenderer = GetComponent<SpriteRenderer>();
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        // Get horizontal and vertical input
        float moveHorizontal = Input.GetAxisRaw("Horizontal");
        float moveVertical = Input.GetAxisRaw("Vertical");

        animator.SetFloat("y", moveVertical);

        // Create a normalized movement vector
        Vector3 movement = new Vector3(moveHorizontal, moveVertical, 0.0f).normalized;

        // Move the player
        transform.Translate(movement * speed * Time.deltaTime);

        // Check if the player is moving
        if (moveHorizontal != 0 || moveVertical != 0)
        {
            // Update Animator for walking
            animator.SetBool("isWalking", true);

            // Flip the sprite based on horizontal direction
            if (moveHorizontal < 0)
            {
                spriteRenderer.flipX = false; // Facing left
            }
            else if (moveHorizontal > 0)
            {
                spriteRenderer.flipX = true; // Facing right
            }
        }
        else
        {
            // Update Animator to idle
            animator.SetBool("isWalking", false);
        }
    }
    // Execise case A
    // private void OnCollisionEnter2D(Collision2D collision)
    // {
    //     Debug.Log($"{name}: OnCollisionEnter2D with {collision.gameObject.name}");
    // }

    // private void OnTriggerEnter2D(Collider2D other)
    // {
    //     Debug.Log($"{name}: OnTriggerEnter2D with {other.name}");
    // }

    // Execise case B
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log($"{name}: OnCollisionEnter2D with {collision.gameObject.name}");
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        Debug.Log($"{name}: OnCollisionExit2D with {collision.gameObject.name}");
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log($"{name}: OnTriggerEnter2D with {other.name}");
    }
    private void OnTriggerExit2D(Collider2D other)
    {
        Debug.Log($"{name}: OnTriggerExit2D with {other.name}");
    }
}