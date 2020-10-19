using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTakeDamageModule : MonoBehaviour
{
    private Player _player;
    // Start is called before the first frame update
    void Start()
    {
        _player = GetComponent<Player>();
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Enemy")
        {
            _player.TakeDamage(other.GetComponent<Enemy>().Damage);
        }
    }
}
