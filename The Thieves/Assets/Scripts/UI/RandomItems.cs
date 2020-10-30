using Assets.Scripts.UI;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomItems : MonoBehaviour
{
    [SerializeField] private Slot[] _slots;
    private Slot _selectedSlot;

    public Slot SelectedSlot
    {
        get { return _selectedSlot; }
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        SelectItem();
    }

    private void SelectItem()
    {
        if(Input.GetKeyDown(KeyCode.Alpha1))
        {
            _selectedSlot = _slots[0];
        }
        if(Input.GetKeyDown(KeyCode.Alpha2))
        {
            _selectedSlot = _slots[1];
        }
        if(Input.GetKeyDown(KeyCode.Alpha3))
        {
            _selectedSlot = _slots[2];
        }
    }
}
