using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Declarar la velocidad de tipo float
    public float speed = 10.0f;
    // Declarar la variable que representará al SpriteRenderer para controlar el 'flip'
    private SpriteRenderer spriteRenderer;

    void Start()
    {
        // Obtener la referencia al SpriteRenderer una sola vez (eficiencia)
        spriteRenderer = GetComponent<SpriteRenderer>();
    }
    void Update()
    {
        // 1. Obtener la entrada con la clase Input
        float moveHorizontal = Input.GetAxisRaw("Horizontal");
        float moveVertical = Input.GetAxisRaw("Vertical");


        // 2. Calcular la traslación espacio = velocidad * tiempo.
        Vector3 movement = new Vector3(moveHorizontal, moveVertical, 0f).normalized;
        transform.Translate(movement * speed * Time.deltaTime);

        // La velocidad se ha declarado previamente, el tiempo lo da Time.deltaTime
        // La traslación se puede hacer con el método Translate del Transform del objeto

        // 3. Alterar la orientación del sprite según se mueva a izquierda o derecha
        if (moveHorizontal < 0)
        {
            spriteRenderer.flipX = true;  // mirando a la izquierda
        }
        else if (moveHorizontal > 0)
        {
            spriteRenderer.flipX = false; // mirando a la derecha
        }
    }
}
