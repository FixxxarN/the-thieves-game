using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerWalkingModule : MonoBehaviour
{
    private Player _player;
    private Rigidbody2D _rigidBody;

    void Start()
    {
        _player = GetComponent<Player>();
        _rigidBody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(_player.IsActive)
        {
            Move();
        }
    }

    private void Move()
    {
        if(Input.GetKey(KeyCode.A))
        {
            _rigidBody.velocity = new Vector2(-_player.Speed, _rigidBody.velocity.y);
        }
        else if (Input.GetKey(KeyCode.D))
        {
            _rigidBody.velocity = new Vector2(_player.Speed, _rigidBody.velocity.y);
        }
        else
        {
            _rigidBody.velocity = new Vector2(0, _rigidBody.velocity.y);
        }
    }
}
