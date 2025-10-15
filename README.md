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
- Persona A, tiene un script de movimiento
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

## b. Un objeto tiene físicas y el otro no.

## c. Ambos objetos tienen físicas.

## d. Ambos objetos tienen físicas y uno de ellos tiene 10 veces más masa que el otro.

## e. Un objeto tiene físicas y el otro es IsTrigger.

## f. Ambos objetos son físicos y uno de ellos está marcado como IsTrigger.

## g. Uno de los objetos es cinemático.

Hacer la configuracion de colicio
![alt text](image-3.png)