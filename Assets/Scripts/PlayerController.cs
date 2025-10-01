// using UnityEngine;

// public class PlayerController : MonoBehaviour
// {
//     public float speed;

//     // Update is called once per frame
//     void Update()
//     {
//         float moveHorizontal = Input.GetAxisRaw("Horizontal");
//         float moveVertical = Input.GetAxisRaw("Vertical");

//         // Create a normalized movement vector
//         Vector3 movement = new Vector3(moveHorizontal, moveVertical, 0.0f).normalized;

//         // Move the object frame rate independently
//         transform.Translate(movement * speed * Time.deltaTime);
//     }
// }