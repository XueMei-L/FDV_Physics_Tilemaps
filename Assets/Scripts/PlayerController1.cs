// using UnityEngine;

// public class PlayerController : MonoBehaviour
// {
//     public float speed;
//     private SpriteRenderer spriteRenderer;
//     void Start()
//     {
//         spriteRenderer = GetComponent<SpriteRenderer>();
//     }

//     // Update is called once per frame
//     void Update()
//     {
//         float moveHorizontal = Input.GetAxisRaw("Horizontal");
//         float moveVertical = Input.GetAxisRaw("Vertical");

//         Vector3 movement = new Vector3(moveHorizontal, moveVertical, 0.0f).normalized;
//         transform.Translate(movement * speed * Time.deltaTime);

//         // Flip the sprite based on horizontal direction
//         if (moveHorizontal < 0) // Moving left
//         {
//             spriteRenderer.flipX = false;
//         }
//         else if (moveHorizontal > 0) // Moving right
//         {
//             spriteRenderer.flipX = true;
//         }
//     }
// }