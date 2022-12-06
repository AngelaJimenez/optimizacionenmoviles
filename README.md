# ColabVRTesis

Este proyecto es un juego que enseña estrategias de optimización en construcción de aplicaciones moviles en realidad virtual.

## Colaboradores

 - Ángela Jimenez
   [LinkedIn](https://www.linkedin.com/in/angelajimenezf/)

 ## Descripción

 El proyecto es un juego en el que una persona se conecta a un ambiente virtual y tiene que solucionar los problemas de optimización que se encuentran en la aplicación, así como tomar decisiones que pueden dificultar el camino en la aplicación (lo que significa problemas de optimización). Se describen 4 cosas en particular: Overdrawing, microoptimizaciones, promesas y memory managment.

 ## Objetivo

 Con este proyecto se busca enseñar diferentes tecnicas y atributos a considerar para mejorar o mantener la optimización en el desarrollo movil en flutter.

## Tecnologías Utilizadas

Este proyecto fue desarrollado en el motor de juegos conocido como Unity, en la versión 2021.3.5f1. Además para la elaboración del juego se utilizaron los siguientes paquetes:

### Paquetes
- FBX Exporter v4.1.2
- JetBrains Rider Editor v3.0.14
- Oculus XR Plugin v 3.0.2 
- TextMeshPro v3.0.6
- Universal RP v12.1.7
- XR Interaction Toolkit v2.0.1
- XR Plugin Management v4.2.1

Por otro lado, todos los assets son tomados de assets publicos en internet, se hizo la modificación de 1 objeto de la escena en Blender para desarrollar una de las salas. Adicionalmente, para mejorar la optimización del proyecto, se usaron tecnicas como occlution culling y LOD.
## Instructivo para ejecución

1. Se utilizó la versión de Unity 2021.3.5f1 por lo cual es necesario su descarga para que todos los archivos sean instalados correctamente.
2. Clonar el repositorio.
3. Abrir UnityHub y agregar el proyecto seleccionando la carpeta donde se clonó el repositorio.
4. Conectar las gafas de realidad virtual y habilitar la opción de quest link. **El juego se debe ejecutar desde el computador, por lo cual es necesario la conexión por cable**
7. Abrir el juego en unity en el computador, y darle play a la escena hubicada en Assets/Scenes/firstmoviles y darle al botón de Play. 

## Herramientas utilizadas
El unico programa aparte de Unity fue 
- Blender: modificación del servidor para poder removerle un bloque y agregarlo en la parte de memory managment.
En Unity se hicieron algunas otras cosas:
- Desarrollo de logica: Todas las salas y las enseñanzas contienen un diseño de logica así como codigo en C# que muestra su desarrollo 
- Desarrollo de interacción: Al ser en realidad virtual, se maneja un desarrollo de interacción con diferentes objetos para prevenir la monotonía y mejorar la experiencia.
