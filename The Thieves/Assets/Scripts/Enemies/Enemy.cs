using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private float _baseHealth;
    private float _baseDamage;

    private float _health;
    private float _damage;

    public float BaseHealth
    {
        private set { _baseHealth = value; }
        get { return _baseHealth; }
    }

    public float BaseDamage
    {
        private set { _baseDamage = value; }
        get { return _baseDamage; }
    }

    public float Health
    {
        private set { _health = value; }
        get { return _health; }
    }

    public float Damage
    {
        private set { _damage = value; }
        get { return _damage; }
    }

    public Enemy()
    {
        _health = 100;
        _damage = 10;
    }

    public void TakeDamage(float damage)
    {
        _health -= damage;
    }
}
