using Godot;
using System;

public partial class Selector : Control
{
    private IDamageable _selectedTarget;

    public void SetSelectedTarget()
    {
        _selectedTarget = GetParent<IDamageable>();
    }
    public void DoSimpleAttack()
    {
        CombatSceneManager.Instance.DoSimpleAttack(_selectedTarget);
    }
}
