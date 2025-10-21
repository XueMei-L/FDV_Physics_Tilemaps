using UnityEngine;

public class PlayerController_Physics2 : MonoBehaviour
{
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