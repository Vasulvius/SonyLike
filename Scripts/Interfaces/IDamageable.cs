
public interface IDamageable
{
    int _currentHealth { get; }
    int _maxHealth { get; }
    void TakeDamage(int amount);
    void Die();
}
