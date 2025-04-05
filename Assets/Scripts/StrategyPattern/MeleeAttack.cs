using UnityEngine;

public class MeleeAttack : IAttack
{
    private string _name;
    private float _range;

    public MeleeAttack(string name, float range)
    {
        _name = name;
        _range = range;
    }
    
    public void Attack()
    {
        Debug.Log($"Melee attack: {_name}, range: {_range}");    
    }
}
