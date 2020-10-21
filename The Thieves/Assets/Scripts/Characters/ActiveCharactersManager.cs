using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ActiveCharactersManager : MonoBehaviour
{
    [SerializeField] private Player[] _players;
    [SerializeField] private Image[] _characterImages;
    private int _activeIndex = 0;

    void Start()
    {
        _players[_activeIndex].SetIsActive(true);
        _characterImages[_activeIndex].color = Color.white;
        for(int i = 1; i < _characterImages.Length; i++)
        {
            _characterImages[i].color = Color.black;
        }
    }

    // Update is called once per frame
    void Update()
    {
        ChangeCharacter();
    }

    private void ChangeCharacter()
    {
        if(Input.GetKeyDown(KeyCode.Tab))
        {
            _players[_activeIndex].SetIsActive(false);
            _characterImages[_activeIndex].color = Color.black;
            if (_activeIndex == _characterImages.Length -1)
            {
                _activeIndex = 0;
            }
            else
            {
                _activeIndex++;
            }
            _characterImages[_activeIndex].color = Color.white;
            _players[_activeIndex].SetIsActive(true);
        }
    }
}
