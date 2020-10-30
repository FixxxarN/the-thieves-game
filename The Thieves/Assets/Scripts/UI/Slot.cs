using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts.UI
{
    public class Slot : MonoBehaviour
    {
        [SerializeField] private Item _item;
        private Image _itemImage;

        public Item Item
        {
            get { return _item; }
        }

        void Start()
        {
            _itemImage = transform.Find("Item").GetComponent<Image>();
            _itemImage.sprite = _item.Texture;
            _itemImage.SetNativeSize();
        }
    }
}
