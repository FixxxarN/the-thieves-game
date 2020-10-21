using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerJumpModule : MonoBehaviour
{
    private Player _player;
    private Rigidbody2D _rigidBody;
    private bool _isGrounded;
    [SerializeField] private Transform _groundCheck;
    [SerializeField] private float _groundCheckRadius;
    [SerializeField] private LayerMask _whatIsGround;

    void Start()
    {
        _player = GetComponent<Player>();
        _rigidBody = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        CheckIfFrounded();
    }

    void Update()
    {
        if(_player.IsActive)
        {
            Jump();
        }
    }

    private void CheckIfFrounded()
    {
        _isGrounded = Physics2D.OverlapCircle(_groundCheck.position, _groundCheckRadius, _whatIsGround);
    }

    private void Jump()
    {
        if (Input.GetKeyDown(KeyCode.Space) && _isGrounded)
        {
            _rigidBody.velocity = new Vector2(_rigidBody.velocity.x, _player.JumpForce);
        }
    }
}
