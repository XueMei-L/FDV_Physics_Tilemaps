# FDV_2D_Sprites

```
>> PRACTICA:   Unity Project - FDV_2D_Sprites
>> COMPONENTE: XueMei Lin
>> GITHUB:     https://github.com/XueMei-L/FDV_2D_Sprites.git
>> Versión:    1.0.0
```

# Proceso de la practica 2D Sprites
## Actividad 1: Agregar el atlas de sprites del personaje a la escena. Configurar el sprite como múltiple y subdividirlo para tener acceso a los sprites para generar las animaciones. Agregar una de las imágenes a la escena.

## Paso 1. Crear un proyecto unity 2D

![alt text](image.png)

## Paso 2. Añadir el atlas de sprites y realizar la configuración
En el **[Assets]** - **[Scenes]**, realizar la configuracion en el panel de **[Inspector]**

Cambiar [sprite Mode] -> [multiple], puesto que hay varios personajes en una imagen, y [Compression] -> [None], significa que no baja la calidad de la imagen.

![alt text](image-1.png)

## Paso 3. Abrir editor de Sprite, y realizar la separación de cada personaje
![alt text](image-2.png)

En **[Slice]** selecciona **[Type]** -> **[Automatic]**, y **[Slice]**, finalmente dar a **[Apply]** y cerrar el editor.

![alt text](image-3.png)

Así ya tenmemos todos los sprites separados automaticamente, ahora añadimos uno en la escena.

![alt text](image-5.png)

## Actividad 2: Creamos un objeto 2D, arrastrando un conjunto de imágenes que selecciones al objeto añadiremos una animación. Agregar al personaje la animación “Walk Down” . Añadir otra imagen y generarle otra animación.  De esa forma Unity crea un objeto Animation, la primera vez que se crea, también añade un objeto Animator Controller.
