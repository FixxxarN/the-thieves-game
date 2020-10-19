using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRunningModule : MonoBehaviour
{
    private Player _player;
    private float _runningSpeed;

    private bool _isRunning;

    public bool IsRunning
    {
        get { return _isRunning; }
    }

    void Start()
    {
        _player = GetComponent<Player>();
        _runningSpeed = 2f;
        _isRunning = false;
    }

    void Update()
    {
        Run();
    }

    private void Run()
    {
        if(Input.GetKey(KeyCode.LeftShift))
        {
            _player.SetSpeed(_runningSpeed);
            _isRunning = true;
        }
        else
        {
            _isRunning = false;
        }
    }
}
