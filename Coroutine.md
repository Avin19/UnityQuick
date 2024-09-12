# Coroutine 

In Unity, a Coroutine is a method use to execute code over a perios of time, allowing for asynchronous operations, delays, and behaviour that spans multiple frames. Coroutines are especially usedul for scenarios where you wnat to control the flow of excuteion without blocking the main game loop, like wating for ecents , tme actions, or sequences that should run alongside the game. 


## Basic Structure of a Coroutine

A Coroutine is declared as a method that retruns `Ienumerator`. Within the coriutine, the `yield` Statement is used to pasue the executions of the methods at certain points. 

```Csharp

public class CoroutineExample : MonoBehaviour
{
    void Start()
    {
        StartCoroutine(MyCoroutine());
    }
    IEnumerator MyCoroutine() {
        Debug.Log("Coroutine started ! ");

        // Wait for 2 Seconds

        yield retrun new WaitForSeconds(2f);

        Debug.Log( "2 Seconds Later .....);

        // Wait for the end of the current frame 

        yield return null;

        Debug.Log(" Ender of frame");
    }
}
```

### key Concepts:

* StartCoroutine(): This functions is used to start a Coroutine. You cannot call Coroutine like normal functions; they need to be initiated using  `StartCoroutine()` . 

* IEnumerator: Coroutine retrun Ienumerator, which  allows the methods to be paused at certain points uusing `yield` statements. 

* yield return : Pauses the Coroutine at that point and waits for the specified condition ( e.g, time delay , next frame , etc. ) before resuming.

## Types of yield Statements :

### 1. `yield retrun new WaitForSeconds(time)` :  Pauses the Coroutine for a set number of seconds . 

```Csharp
IEnumberator WaitExample()
{
    yield return new WaitForSceonds(3f);

    // waits for 3 seconds 

    Debug. Log(" 3 Seconds Later ");


}
```
### 2. `yield return null ` : pauses the Coroutine until the next frame.

``` Csharp
IEnumerator WaitNextFrame()
{
    yield return null;
    // waits unit the next frame 
    Debug.Log(" Resuming in the next frame ...");
        
}
```
### 3. `yield retrun new waitForEndOfFrame()` : Waits unitl the end of the current frame before continuing.

``` Csharp
Ienumerator EndOfFrameExample() {
    yield return new WaitForENdOfFrame();
    // Waits untill the end of the frame
    Debug.Log("End of frame reached.");

}
```
### 4. `yield retrun new WaitUnti(Condition)` : Waits until a specific conditon become true before continuing.

```Csharp
IEnumerator WaitUnitlExample()
{
    yield return nre WaitUntil( () => Time.time > 5f);
    Debug.Log( " TIme is greater than 5 second");
}
```

### 5. `yield retrun  new WaitWhile(Condition)` : Waits while a condition remains true before continuing. 
``` Csharp

IEnumerator WaitWhileEXample(){
    yield return new WaitWhile( () => Input.GetKey(KeyCode.Space));
    // Waits while the spacebar is held down 
    Debub.Log(" Space Key released.");
}

```
# Stopping a Coroutine 

Coroutines can be stopped before they finish execution using `StopCoroutine() ` or globally stopped using `StopAllCoroutines()`.

```Csharp
public class CoroutineStopExample : Monobehaviour {
    private Coroutine myCoroutine;

    void Start()
    {
        myCoroutine = StartCoroutine(MyCoroutine());
    }
    Ienumerator MyCoroutine() 
    {
        while(true)
        {
            Debug.Log("Running .... ");
            yield return new WaitForSeconfs(1f);

        }
    }
    void Update 
    {
        if(Inout.GetkeyDown(KeyCode.S))
        {
            StopCoroutine(myCoroutine);
            //Stops the Specific Coroutine
            Debug.Log(" Coroutine stopped . " );


        }
    }
}
```
In this example, pressing the `S` key will stop the running Coroutine.


## Use Cases for Coroutines

## 1. Timed Events: Performing actions after a delay ( e.g, relaoding a weapon, spawning enemies after a countdown).

``` Csharp

IEnumerator ReloadWeapon()
{
    Debug.Log(" Reloading ... ");
    yield retrun new WaitForSeconds(2f);
    // wait 2 seconds to simulate reload time.
    Debug.Log(" Weapon  reloaded. ");
}

```
## 2. Sequencing Events:  Running a Series of actions in a timed sequence.
```Csharp
IEnumerator EventSequence()
{
    Debug.Log("Start of sequence.");
    yield return new WaitForSeconds(1f);
    Debug.Log(" 1 Second Passed. ");
    yield return new WaitForSeconds(2f);
    Debug.Log(" 3 Seconds passed.");    
}
```
## 3. Smooth Transition: Gradually Changing a value over time ( e.g., fading otut a UI element, moving an object smoothly).

``` Csharp 

IEnumerator FadeOut( Canvasgroup canvasgroup, float duration) {
    float startAlpha = CanvasGroup.alpha;
    for(float t = 0; t < duration ; t += Time.deltaTime)
    {
        canvasGroup.alpha = Mathf.Lerp ( startAlpha, 0 ,t/ duration);

    }
    canvasGroup.alpha = 0 ;
}
```

## 4. Loading Scenes : Running a loading sceen while waitng for another scene to load. 

```CSharp 

IEnumerator LoadSceneAsync( string sceneName)
{
    AsyncOperation asyncLoad = SceneManager.LoadSceneAsync(sceneName);
    While(!asyncLoad.IsDone)
    {
        yield return null;
    }
    Debug.Log(" Scene Loaded");


}
```

# Coroutine vs Update()

* Coroutines allow you to break up execution over time without vlocking the main game loops, whereas `Update()` euns code every frame. Coroutines are greatefor timed delays or sequences. 

* Coroutines are more performance-friendly for tasks taht dont need to run every frame.
For example, handling animations or waiting for specific events should be coroutines rather than putting everything in ` Update()`. 
