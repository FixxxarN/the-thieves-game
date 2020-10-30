using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShootAndThrowModule : MonoBehaviour
{
    private Player _player;
    [SerializeField] private GameObject _itemToBeThrown;

    void Start()
    {
        _player = GetComponent<Player>();
    }

    // Update is called once per frame
    void Update()
    {
        if(_player.IsActive)
        {
            Throw();
        }
    }

    private void Throw()
    {
        if(Input.GetKeyDown(KeyCode.X))
        {
            Vector2 target = Camera.main.ScreenToWorldPoint(new Vector2(Input.mousePosition.x, Input.mousePosition.y));
            Vector2 myPos = transform.Find("Arm").transform.Find("Item").transform.position;
            Vector2 direction = target - myPos;
            direction.Normalize();
            GameObject itemToBeThrown = (GameObject)Instantiate(_itemToBeThrown, myPos, Quaternion.identity);
            itemToBeThrown.GetComponent<Rigidbody2D>().velocity = direction * 6;
        }
    }
}
