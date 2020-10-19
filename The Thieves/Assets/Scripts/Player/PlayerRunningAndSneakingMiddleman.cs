using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRunningAndSneakingMiddleman : MonoBehaviour
{
    private Player _player;
    private PlayerRunningModule _playerRunningModule;
    private PlayerSneakingModule _playerSneakingModule;

    void Start()
    {
        _player = GetComponent<Player>();
        _playerRunningModule = GetComponent<PlayerRunningModule>();
        _playerSneakingModule = GetComponent<PlayerSneakingModule>();
    }

    // Update is called once per frame
    void Update()
    {
        ResetPlayerBaseSpeed();
    }

    private void ResetPlayerBaseSpeed()
    {
        if(!_playerRunningModule.IsRunning && !_playerSneakingModule.IsSneaking)
        {
            _player.SetSpeed(_player.BaseSpeed);
        }
    }
}
