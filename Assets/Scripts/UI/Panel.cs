﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Game.UI
{
    public class Panel : MonoBehaviour
    {
        [SerializeField] private Text _text;
        [SerializeField] private Image _background;

        public void SetText(string text){
            _text.text = text;
        }
    }
}

