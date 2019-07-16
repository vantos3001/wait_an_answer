using System.Collections;
using System.Collections.Generic;
using Game.UI;
using UnityEngine;
using UnityEngine.UI;

public class UICanvas : MonoBehaviour
{
    [SerializeField] private Canvas _canvas;
    
    [Header("Buttons")]
    public Button EatButton;
    public Button SleepButton;
    public Button WorkButton;
    public Button RelaxButton;
    public Button CheckEmailButton;

    [Header("Panels")] 
    [SerializeField] private Panel _eatPanel;
    [SerializeField] private Panel _sleepPanel;
    [SerializeField] private Panel _workPanel;
    [SerializeField] private Panel _moodPanel;

    private GameController _gameController;

    private const string PREFIX_EAT_PANEL = "Сытость: ";
    private const string PREFIX_SLEEP_PANEL = "Бодрость: ";
    private const string PREFIX_WORK_PANEL = "Работа: ";
    private const string PREFIX_MOOD_PANEL = "Настроение: ";
    
    public void SetEatPanelText(string value){
        var text = PREFIX_EAT_PANEL + value;
        _eatPanel.SetText(text);
    }
        
    public void SetSleepPanelText(string value){
        var text = PREFIX_SLEEP_PANEL + value;
        _sleepPanel.SetText(text);
    }
        
    public void SetWorkPanelText(string value){
        var text = PREFIX_WORK_PANEL + value;
        _workPanel.SetText(text);
    }
        
    public void SetMoodPanelText(string value){
        var text = PREFIX_MOOD_PANEL + value;
        _moodPanel.SetText(text);
    }
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
