using Godot;
using System;

public partial class CombatSceneManager : Node
{
    private static CombatSceneManager _instance;

    public static CombatSceneManager Instance => _instance;

    public override void _Ready()
    {
        if (_instance != null && _instance != this)
        {
            QueueFree();
            return;
        }

        _instance = this;
    }

    public void DoSimpleAttack(IDamageable target)
    {
        if (target == null)
        {
            GD.Print("No target to attack.");
            return;
        }

        int damage = 10;
        target.TakeDamage(damage);
    }
}
