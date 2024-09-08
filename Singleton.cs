public class GameManager : MonoBehaviour
{

    public static GameManager Instance { get; private set; }

    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestoryOnLoad(gameObject); // Persist through scene loads 
        }
        else
        {
            Destory(gameObject);
        }
    }
}