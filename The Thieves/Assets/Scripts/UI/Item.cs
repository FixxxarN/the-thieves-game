﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Scripts.UI
{
    public class Item : MonoBehaviour
    {
        public Sprite Texture;
        [SerializeField] private bool _shouldBeRotated;

        public bool ShouldBeRotated
        {
            get { return _shouldBeRotated; }
        }
    }
}
