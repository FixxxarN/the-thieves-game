using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShootAndThrowModule : MonoBehaviour
{
    [SerializeField] private GameObject _itemToBeThrown;

    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        Throw();
    }

    private void Throw()
    {
        if(Input.GetKeyDown(KeyCode.X))
        {
            Vector2 target = Camera.main.ScreenToWorldPoint(new Vector2(Input.mousePosition.x, Input.mousePosition.y));
            Vector2 myPos = new Vector2(transform.position.x, transform.position.y + 0.3f);
            Vector2 direction = target - myPos;
            direction.Normalize();
            GameObject itemToBeThrown = (GameObject)Instantiate(_itemToBeThrown, myPos, Quaternion.identity);
            itemToBeThrown.GetComponent<Rigidbody2D>().velocity = direction * 6;
        }
    }
}
