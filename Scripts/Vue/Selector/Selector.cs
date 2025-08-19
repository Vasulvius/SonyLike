using Godot;

public partial class Selector : Control
{
    private IDamageable _selectedTarget;

    public void SetSelectedTarget()
    {
        _selectedTarget = GetParent<IDamageable>();
    }
    public void DoSimpleAttack()
    {
        if (_selectedTarget == null)
        {
            GD.Print("No target to attack.");
            return;
        }

        int damage = 10;
        _selectedTarget.TakeDamage(damage);

        CombatSceneManager.Instance.HandleCharacterEndTurn();
    }
}
