# Possible Question that can be asked 

1. `OnEnable()` vs `Start()`

# 1. `OnEnable()`

* Purpose
    - The `OnEnable()` method is called when the object( or the script component) is enabled. This can happen when :
         * The GameObject is first instantiated and is enabled.
         * The GameObject is re-enabled adter being disabled. 
         * The script Component itself is enabled after being disabled.

* Use Cases:
    - Initializing or restting certain variables or subscribing to events.
    - Restarting timers, Coroutines, or other behaviors when the object or script becomes active again.
    - Useful when you want to execute code every time the object is enabled, even if it happens multiple time during the object's lifecycle. 


```CSharp 

public class EaxmpleScript : MonoBehaviour {
    void OnEnable()
    {
        Debug.Log("object or script is enabled.");
        // Subscribe to events, start action
    }
    void OnDisable()
    {
        Debug.Log("Object or script is disabled.");
        // Unsubscribe from events or stop actions
    }
}
```
### Key Notes On `OnEnable() `:

 * It can be called multiple times in the object's lifecycle if the object or script is repeatedly enabled/disabled.

 * It runs before ` Start()` , so if you need something to initialize before `Start()`, `OnEnable()` can be a good place for that.

 *Paired with `OnDisable()` to handle the reverse logic when the object is disabled (e.g., unsubscribing from events or stopping coroutines).


# 2. `Start()`

Purpose:

* The `Start()` method is called once when the script is first enabled. It runs before the first frame update, but only after all `Awake()` methods have been called and the scene has been loaded.

Use Cases:

* One-time initialization that only needs to happen at the beginning of the object's lifecycle.

* loading data, setting up references, or starting behaviors that are needed once the script is fully initialized.

* typically used for game logic initialization that happens right after the scene has loaded  and the object is ready to act.

```Csharp

public class ExampleScript : Monobehaviour {
    void Start()
    {
        Debug.Log("Start method called once when the object is initialized.");
        //One-time initialization

    }

}

```
### Key Notes on `Start()` :

* It is only called once per script, even if the GameObject is disabled and re-enabled later.

* If a GameObject is instantiated in the middle of the game, `Start()` will be called immediately after it is instantiated and enabled.

*`Start()` is typically used for initial setup that does not need to be repeated when the object is disabled and re-enabled.


## Comparison of `OnEnable()` and `Start()`

|Aspect| OnEnable() | Start()|
|------|------------|--------|
|When it is called ?| Every time the object/Script is  enabled.|Once, when the object is first initialized and enabled.|

