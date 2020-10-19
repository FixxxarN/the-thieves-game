using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private float _health;
    private float _damage;
    private float _speed;
    private float _jumpForce;

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

    public float JumpForce
    {
        private set { _jumpForce = value; }
        get { return _jumpForce; }
    }

    public Player()
    {
        _health = 100f;
        _damage = 10f;
        _speed = 1f;
        _jumpForce = 3;
    }
}
