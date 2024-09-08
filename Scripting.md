# Scripting in Unity

 is a Core aspect of game developement, allowing developers to create custom behaviours, Control game logic, and interact with other Unity Systems. Unity primarily uses c# for scripting. Below is a more in-depth look at key scripting concepts, features, and practices in Unity:

## 1. MonoBehaviour

* Base Class: Almost all Unity Scripts derive from the MonoBehaviour class. This provides a structure for how scripts interact with the Unity engine.

* Lifecycle Methods:

    - Awake() : Called when the script instance is being laoded. Used for initialization before Start().

    - Start(): Called before the first frame update. Initialization code can go here if you need something afete the scene has fully loaded.

    - Update(): Called once per frame. Commonly used for real-time updates such as cheaking for user input or moving objects.

    - FixedUpdate() : Called at fixed intervals, indpendent of frame rate. IT is typically ised for physics-related updates like Rigidboay movement.

    - LateUpdate() : Called after all Update() methods. Useful for iperations that need to happen after the game logic updates ( like camera following).

    - OnEnable()/ OnDisable() : Called when the object is enabled/disabled.

    - OnDestroy() : Called when the object is destoryed, good for cleanup logic.

    -On triggerEnter() / OnCollisionEnter() : Handles physic-based interactions such as when objects collide or enter trigger zones.

    ## 2. Variables and Access Modifiers

    * Public vs Private Varaible : 
        - public : Varaible accessible bt other classes and shown in the Unity Inspectper.

        - private: Varaible that are only accesssible within the script and are hidden from the Inspector unless explicitly serialized.

        - Serialized Fields: Even private fileds can be made editable in the Unity Inspector using [SerializeField]

        [Link](/Variable.cs)
    ## 3. Unity's inout System

    * Old Input System: Use Input.GetAxis(), Inout.GetKey(), and Input.GetMouseButton() to handle player inout.

        [Link](/Input.cs)
    * New Input System: More complex and flexible , allowing support for multiple input devices ( gamepad, touch, mouse). It uses action maps and events for inout detection.

    ## 4. Coroutines

    * Coroutines allow you to pause the execution of a function and resum it after a certain condition is met or a time delay has passed.

    * Useful for creating timed actions, such as animations, delays between attacks, or loading screens.

    [Link](/DelayAction.cs)

## 5. Physics and Rigidbody Control

    * Unity's Physics System uses the Rigidbody component to enavle physocs behavior. Scripts can apply forces, set velocity, or handle physics-based movement. 

    [Link](/Rigidbody.cs)


