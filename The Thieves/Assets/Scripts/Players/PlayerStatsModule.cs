using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerStatsModule : MonoBehaviour
{
    private Player _player;
    [SerializeField] private Image _healthBarImage;
    // Start is called before the first frame update
    void Start()
    {
        _player = GetComponent<Player>();
    }

    void Update()
    {
        UpdateHealth();
    }

    private void UpdateHealth()
    {
        _healthBarImage.rectTransform.localScale = new Vector2(_player.Health / 100, 1);
    }
}
