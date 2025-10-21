FDV_Tilemaps

```
>> PRACTICA:   Unity Project Tilemaps
>> COMPONENTE: XueMei Lin
>> GITHUB:     https://github.com/XueMei-L/FDV_Physics_Tilemaps.git
>> Versión:    1.0.0
```

# Objetivo
En esta actividad realizaremos pruebas con el motor de físicas 2D y el editor de mapas 2D que proporciona Unity. Los componentes de mayor interés son：

- Rigidbody: Acceso a las simulaciones físicas
- Collider: Detección de las colisiones.


Respecto al mapa de juego, se debe trabajar con los objetos:

- Grid
- Tilemap
- Tile Palette
- Tile map collider
- Composite collider
  
# Proceso de la práctica Tilemaps (Unity)

Reutilizamos el proyecto anterior 2D, creamos otra escena llamado `ScenePhysics2D` para la practica de Tilemaps, además duplicamos nuestro objeto para probar diferentes configuraciones de objetos
físicos en Unity.

![alt text](image-1.png)
![alt text](image-2.png)



## Caso A. Ninguno de los objetos será físico.
Configuración de personajes:
- Persona A, tiene un script de movimiento (incluye códigos de eventos **OnCollision2D** y **OnTrigger2D**)
- Persona B, nada de script
- Ninguna configuración de **Rigidbody** y **Collider**

Resultado:

| Objeto   | Rigidbody2D | Collider2D | Reacción física | Eventos |
|-----------|--------------|-------------|------------------|----------|
| PersonA   | NO           | NO          | NO               | NO       |
| PersonB   | NO           | NO          | NO               | NO       |

Resultado en git:

Hice una configuración de **Persona A** -> **Inspector** -> **Sprite Renderer** -> **Order in Layer** -> cambiar valor a 1 (para tener la visualización de mayor prioridad)

![alt text](image-4.png)

![alt text](Unity_p7zgHcbcQD.gif)

## b. Un objeto tiene físicas y el otro no.
| Objeto   | Rigidbody2D | Collider2D | Reacción física | Eventos |
|-----------|--------------|-------------|------------------|----------|
| PersonA   | SÍ           | SÍ          | SÍ               | SÍ       |
| PersonB   | NO           | NO          | NO               | NO       |

Añadir Box Collider 2D y Rigibody 2D a Player A.
![alt text](image-5.png)

Resultado en gif:
Se puede ver que cuando el personaje tiene fisica, se cae y choca con el suelo, el comando muestra mensaje -> (la funcion **OnCollision2D**)

Código añadido para dos jugares a parte de la práctica anterior (2D Sprites)
```
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
```
![alt text](Unity_EvWZtKvigX.gif)

## c. Ambos objetos tienen físicas.
Añadimos Collider 2D y Rigibody 2D al persona B.
![alt text](image-6.png)

Resultado: Se puede ver que ambos tienes fisicas y se caen encima del muro. Si el jugador A colliona con el jugador B, se puede empujar el jugar, no se puede atravezar.

| Objeto   | Rigidbody2D | Collider2D | Reacción física | Eventos |
|-----------|--------------|-------------|------------------|----------|
| PersonA   | SÍ           | SÍ          | SÍ               | SÍ       |
| PersonB   | SÍ           | SÍ          | SÍ               | SÍ       |

![alt text](Unity_AcD9NbOS4S.gif)

## d. Ambos objetos tienen físicas y uno de ellos tiene 10 veces más masa que el otro.
Cambiamos la masa en el Rigibody2D del jugador B a 10, es 10 veces más que el jugador A.

![alt text](image-7.png)

Resultado:
Se puede ver el resultado que el jugador A empuja al jugador B más lento.

| Objeto   | Rigidbody2D | Collider2D | Reacción física | Eventos |
|-----------|--------------|-------------|------------------|----------|
| PersonA   | SÍ           | SÍ          | SÍ               | SÍ       |
| PersonB   | SÍ           | SÍ          | SÍ               | SÍ       |

![alt text](Unity_HqqfQ5Fyrg.gif)

## e. Un objeto tiene físicas y el otro es IsTrigger.

## f. Ambos objetos son físicos y uno de ellos está marcado como IsTrigger.

## g. Uno de los objetos es cinemático.

Hacer la configuracion de colicion
![alt text](image-3.png)