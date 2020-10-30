using Assets.Scripts.UI;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHoldItemModule : MonoBehaviour
{
    private RandomItems _randomItems;
    private Item _itemInHand;
    void Start()
    {
        _randomItems = GameObject.Find("Random Items Manager").GetComponent<RandomItems>();
    }

    void Update()
    {
        if(_randomItems.SelectedSlot != null)
        {
            _itemInHand = _randomItems.SelectedSlot.Item;
            if(_itemInHand != null)
            {
                if(_itemInHand.Texture != transform.Find("Arm").transform.Find("Item").gameObject.GetComponent<SpriteRenderer>().sprite)
                {
                    transform.Find("Arm").transform.Find("Item").gameObject.GetComponent<SpriteRenderer>().sprite = _itemInHand.Texture;
                    if(_itemInHand.ShouldBeRotated)
                    {
                        transform.Find("Arm").transform.Find("Item").localRotation = Quaternion.Euler(0f, 0f, 270f);
                    }
                }
            }
        }
    }
}
