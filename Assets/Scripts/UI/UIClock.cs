using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIClock : MonoBehaviour
{
    private const string PREFIX_TIME = "Time: ";
    private const string DEFAULT_START_TIME = "05:05";
    

    
    [SerializeField] private Image _background;
    [SerializeField] private Text _timerText;

    public void UpdateTime(string time){
        _timerText.text = PREFIX_TIME + time;
    }
}
