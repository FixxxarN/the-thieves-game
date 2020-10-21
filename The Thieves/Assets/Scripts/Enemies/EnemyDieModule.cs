using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDieModule : MonoBehaviour
{
    private Enemy _enemy;

    void Start()
    {
        _enemy = GetComponent<Enemy>();
    }

    void Update()
    {
        CheckIfDead();
    }

    private void CheckIfDead()
    {
        if (_enemy.Health <= 0)
            Die();
    }

    private void Die()
    {
        Destroy(_enemy.gameObject);
    }
}
