using UnityEngine;

public class RotacionYMovimientoLocal2D : MonoBehaviour
{
    // Variables ajustables en el Inspector
    // Velocidad de traslación hacia adelante
    public float speed = 5f;
    // Velocidad de rotación (grados por segundo)
    public float rotationSpeed = 200f;

    void Update()
    {
        // 1. OBTENER LAS ENTRADAS

        // Input para la rotación (izquierda/derecha) con el eje Horizontal
        float rotationInput = Input.GetAxis("Horizontal"); // izquierda/derecha

        // Input para el movimiento hacia adelante/atrás con el eje Vertical
        float moveInput = Input.GetAxis("Vertical");       // arriba/abajo


        // 2. APLICAR ROTACIÓN (Giro del Objeto sobre el Eje Z) proporcional a Time.deltaTime para suavizar el giro.
        // Gira el objeto sobre su Eje Z. El componente Transform tiene la función Rotar.
        transform.Rotate(0, 0, -rotationInput * rotationSpeed * Time.deltaTime);

        // 3. APLICAR TRASLACIÓN EN EL ESPACIO LOCAL (Avanzar), una vez que hemos rotado.
        // Creamos un vector que solo tiene movimiento en el EJE Y, porque ya se ha rotado.
        // transform.Translate() con Space.Self es la clave, en este caso es necesario mover el objeto en la dirección que mira (su espacio local),
        // no en el espacio global.
        Vector3 movement = new Vector3(0, moveInput * speed * Time.deltaTime, 0);
        transform.Translate(movement, Space.Self);
    }
}