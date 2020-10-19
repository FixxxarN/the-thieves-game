using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSneakingModule : MonoBehaviour
{
    private Player _player;
    private float _sneakSpeed;

    private bool _isSneaking;

    public bool IsSneaking
    {
        get { return _isSneaking; }
    }

    void Start()
    {
        _player = GetComponent<Player>();
        _sneakSpeed = 0.5f;
        _isSneaking = false;
    }

    // Update is called once per frame
    void Update()
    {
        Sneak();
    }

    private void Sneak()
    {
        if(Input.GetKey(KeyCode.LeftControl))
        {
            _player.SetSpeed(_sneakSpeed);
            _isSneaking = true;
        }
        else
        {
            _isSneaking = false;
        }
    }
}
