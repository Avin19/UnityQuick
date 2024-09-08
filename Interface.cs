public interface IDamageable
{
    void TakeDamage(int damage);
}

public class Enemy : MonoBehaviour, IDamageable
{
    public void TakeDamage(int damage)
    {
        // Enemy takes damage
    }
}