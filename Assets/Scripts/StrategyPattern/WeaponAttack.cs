using UnityEngine;

public class WeaponAttack : IAttack
{
    private string _name;
    private int _weaponDamage;

    public WeaponAttack(string name, int damage)
    {
        _name = name;
        _weaponDamage = damage;
    }
    
    public void Attack()
    {
        Debug.Log($"Attacando con Weapon: {_name}, Daño realizado: {_weaponDamage}");
    }

    private void Load()
    {
        
    }
    
    private void Reload()
    {
        
    }
}
