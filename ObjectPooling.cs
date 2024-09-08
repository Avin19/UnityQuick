public class ObjectPool : Monobehaviour
{

    public GameObject perfab;

    private Queue<GameObject> pool = new Queue<GameObject>();

    public GameObject Getobject()
    {
        if (pool.Count > 0)
        {
            return pool.Dequeue();
        }
        else
        {
            return Instantiate(prefab);
        }

    }
    public void ReturnObject(GameObject obj)
    {
        obj.SetActive(false);
        pool.Enqueue(obj);
    }
}
