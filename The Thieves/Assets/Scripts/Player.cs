using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private float _health;
    [SerializeField] private float _damage;
    [SerializeField] private float _speed;

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

    public float Speed
    {
        private set { _speed = value; }
        get { return _speed; }
    }

    public Player()
    {
        _health = 100f;
        _damage = 10f;
        _speed = 1f;
    }
}
