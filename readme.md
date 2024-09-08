# Unity Quick For Interview 

Unity is a powerful and widely-used game engine, offering a comprehesive set of tools for game development acrss various platforms. Here are the key concepts to understand in Unity:

## 1. Unity Editor

* Scene View : Where you build and organizer the environment, positioning assests like characters, props , and cameras.

* Game View : Simulates the actual gameplay and how the player will experience the game.

* Hierarchy : Contains all the GameObjects in the current scene, showing their hierarchy ( parent - child relationships).

* Inspector : Displays the components of s selected GameObject. You can modify properties like position, scale, and add/remove components.

* Project panel: Organizes assets ( textures , scripts, perfabs) and resources used in the game.

## 2. GameObjects and Components

* GameObjects: The fundamentatl objects in Unity, representing characters, props, lights, etc. Everything in a scene is a GameObject.

* Components: Modular pieces of functionality ( eg Transfrom , Collider, Render) 
attached to GameObjects. Each adds specific behavior or data.

* Tranfrom: Every Gameobject has a Transfomr component that defines it position, rotation,  and scale in the game world. 

## 3. Scripting (C# )

* MonoBehaviour: The base class for unity Script.Scripts inherit from this class and control behavuoir through functions like Update(), Start(),  and On triggerEnter().

* Update: Runs every frame, used for real-time updates like input handling and movement.

* FixedUpdate: used for physics-related updates, called at a consistent time interval.

*Corountines: Functions that allow delayed or asynchronous behaviour, running over multiple frames. 

## 4. Physics System .

* Rigidbody : A componentn that enavles GameObject to behave according to phsyics laws, affected by forces, gravity , and collisions. 

* Colliders: Define the shape of GameObjects for collision detection. BoxCollider, Sphere Collider, and Mesh Collider are Common types.

* Triggers : A Collider set as a trigger doesn't physically interact but detects when another object enters or exits the trigger zone. 


## 5. 2D and 3D Graphics

* 2d mode : Specialized components like spriteRenderer, 2D colliders,  and Rigidbody2D allow for efficient 2D game development.

* 3D Mode: Use MeshRenderer for rendering 3D models. and handle more complex lighting, shaders, and physics.

* Shaders and Materials: Materials define the visual appearance of GameObjects, often using shaders to control how thay interact with light. 


## 6. Prefabs 

* Perfabs are reusable templates for GameObjects. Once created, changes to the prefab can be applied across all instances of the perfab in the game. 

## 7. Uers Interface( UI)

* Unity provides tools for creating in-game UIs like health bars, menus, and score displays using the Canvas system.

* Common UI elements include Text, Image, Button , and Slider.

* The UI is rendered is a special UI layer to ensure consistency across different devices and resolutions.

## 8. Input System

* Input Manager: Handles user inout for devices like keyboard. mouse, touch, and controllers. You can map input axes( e.g., "Horizontal" and "Vertical") or detect specific key presses.

* New Inout System: Allows more flexible input management, supporting multiple devices and more complex control schemes.

## 9. Animation System

* Animation: A system to control character animations using Animator Controller, which  links animations to various states and transitions based on conditions.

* Animation Clips: keyframe-based animations that degine how a Gameobject or chatacter moves over time.

* Blend Trees: Allow smooth transitions between animations, like walking and running based on speed.

## 10. AI and Navigation

* NavMesh : A system for creating paths that characters or AI can follow, navigationg around obstacles.

* NavMesh Agents: Control GameObjects that need to navigate along the NavMEsh, like NPC's or enemies.

## 11. Audio System

* AudioSource: Plays audio clips on GameObjects, with control over volume, pitch and 3D sound effects ( spatial Audio).

* AudioListener: Represents the point where audio is heard ( often attached to the camera).

## 12. Lighting System

* Real-time Lighting: Lights calculated dynamically, useful for things like moving lights or changing environments.

* Baked Lighting: Pre-Computed light data for static environments, improving performance.

* Light Types: Point, Directional, and Spotlights are commonly used to simulate different lighting effects.

*Global Illumination: Simulates how light nounces off surfaces to create more realistic lighting.

## 13. Particles and Visual Effects

* Particle System : Allows creating dynamic visual effects like smoke,fire, abd explosions. You can adjust paramters like emission rate, lifetime, size, and color.

* VFX Graphs: Amore advanced tool for creating GPU-based visual effects, providing better performance for complex effects.

## 14. Networking (Multiplayer)

* Unity Multiplayer Serives ( NetCode) : Provides tools to implement multiplayer features like synchroizing GameObject states across clients.

* Photon/Unet: Popular third-party solutions to implement neteorking features sucha s matchmaking, lobbies, and in-game synchronization.

## 15. Optimization Techniques

* Occlusion Culling: Ensure only visible objects are rendered, saving performance.

* level of Detail (LOD): Adjusts the detail level of distance objects, reducing geometry and texture resolution.


*Profiling: Unity's Profiler helps measure performace, identify bottlenecks in CPU, GPU, memory, and rendering.

## 16. Asset Store

* Unity's Asset Store provides a marketplace where developers can purchase or download free assests like models, textures, scripts, and plugins to speed up development.

## 17. Build and Deployment

* Build Settings: Allow you to select target platforms ( Windows , Android, iOS, WebGL etc.) and configure game settings before creating the executable.

* Player Settings : Adjust game-specific setting such as resolution, splash screen, and icon.


## 18. Package Manager 

* used to manage external Uity packages and libraries. IT allows you to impoet features like Post-Processing, Cinemachine, or even third-party tools directly into the project.

## 19. Version Control Integration

* Unity Collaborate: An easy-to-use version control system for small teams built into Unity.

Git: The most popular version control system, Commonly integrated with Unity projects using .gitignore for Unity-specific files.

# `OnEnable()` vs `Start()`

[Ouestion](/Question.md)

# `Update()` vs `FixedUpdate()` vs `LateUpdate()`

[Question](/Question2.md)