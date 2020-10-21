using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDieModule : MonoBehaviour
{
    private Player _player;

    void Start()
    {
        _player = GetComponent<Player>();
    }

    void Update()
    {
        CheckIfDead();
    }

    private void CheckIfDead()
    {
        if (_player.Health <= 0)
            Die();
    }

    private void Die()
    {
        Destroy(_player.gameObject);
    }
}
