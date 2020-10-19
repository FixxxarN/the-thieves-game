using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyTakeDamageModule : MonoBehaviour
{
    private Enemy _enemy;
    // Start is called before the first frame update
    void Start()
    {
        _enemy = GetComponent<Enemy>();
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            _enemy.TakeDamage(other.GetComponent<Player>().Damage);
        }
    }
}
