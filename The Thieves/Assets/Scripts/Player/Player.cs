using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private float _baseHealth;
    private float _baseDamage;
    private float _baseSpeed;
    private float _baseJumpForce;

    [SerializeField] private float _health;
    private float _damage;
    private float _speed;
    private float _jumpForce;

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

    public float BaseSpeed
    {
        private set { _baseSpeed = value; }
        get { return _baseSpeed; }
    }

    public float BaseJumpForce
    {
        private set { _baseJumpForce = value; }
        get { return _baseJumpForce; }
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
        _baseHealth = 100f;
        _baseDamage = 12f;
        _baseSpeed = 1f;
        _baseJumpForce = 3f;

        _health = 100f;
        _damage = 12f;
        _speed = 1f;
        _jumpForce = 3f;
    }

    public void SetSpeed(float speed)
    {
        _speed = speed;
    }

    public void TakeDamage(float damage)
    {
        _health -= damage;
    }
}
