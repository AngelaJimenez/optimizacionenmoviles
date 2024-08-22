
# **OptiScape: Use all the optimization strategies to save your spaceship.**

This project is a game that teaches optimization strategies in mobile application development within a virtual reality environment. Most of it is in spanish.

## **Contributors**

- Ángela Jimenez  
  [LinkedIn](https://www.linkedin.com/in/angelajimenezf/)

## **Description**

The project is a game where a person connects to a virtual environment and must solve optimization problems within the application, as well as make decisions that can complicate the application’s path (which means optimization challenges). Four specific areas are covered: Overdrawing, micro-optimizations, promises, and memory management.

## **Objective**

The goal of this project is to teach different techniques and attributes to consider in order to improve or maintain optimization in mobile development using Flutter.

## **Technologies Used**

This project was developed using the Unity game engine, version 2021.3.5f1. Additionally, the following packages were used in the creation of the game:

### **Packages**
- FBX Exporter v4.1.2
- JetBrains Rider Editor v3.0.14
- Oculus XR Plugin v3.0.2 
- TextMeshPro v3.0.6
- Universal RP v12.1.7
- XR Interaction Toolkit v2.0.1
- XR Plugin Management v4.2.1

Furthermore, all assets were sourced from public assets available online, with one object in the scene modified using Blender to develop one of the rooms. Additionally, techniques like occlusion culling and LOD were implemented to enhance the project's optimization.

## **Execution Instructions**

1. Unity version 2021.3.5f1 was used, so it is necessary to download this version for all files to be installed correctly.
2. Clone the repository.
3. Open UnityHub and add the project by selecting the folder where the repository was cloned.
4. Connect the VR headset and enable the Quest Link option. **The game must be run from the computer, so a cable connection is required.**
5. Open the game in Unity on the computer, navigate to the scene located in `Assets/Scenes/firstmoviles`, and click the Play button.

## **Tools Used**

- **Blender**: Modified the server object where data is stored. A block was removed from this object, creating the space where data blocks must be inserted in the memory management section.
- **Logic Development**: All rooms and lessons contain logic design and include C# code that demonstrates their development.
- **Interaction Development**: Being in virtual reality, interaction with different objects is managed to prevent monotony and improve the experience. The XR Interaction Toolkit is specifically used for functionality.
