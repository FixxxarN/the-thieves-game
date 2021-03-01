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

    void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.tag == "Enemy")
        {
            _player.TakeDamage(other.gameObject.GetComponent<Enemy>().Damage);
        }
    }
}
