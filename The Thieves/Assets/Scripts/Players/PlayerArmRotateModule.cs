using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerArmRotateModule : MonoBehaviour
{
    private Player _player;

    void Start()
    {
        _player = transform.parent.GetComponent<Player>(); 
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (_player.IsActive)
        {
            RotateArm();
        }

    }

    private void RotateArm()
    {
        Vector2 difference = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;

        difference.Normalize();

        float rotationZ = Mathf.Atan2(difference.y, difference.x) * Mathf.Rad2Deg;

        transform.rotation = Quaternion.Euler(0f, 0f, rotationZ + 90);
    }
}
