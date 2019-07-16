using UnityEngine;
using UnityEngine.UI;

namespace Game.UI
{
    public class UIManager
    {
        private static UIManager _instance;
        private UICanvas _canvas;
        private GameController _gameController;

        public static UIManager Instance(){
            if (_instance == null){
                _instance = new UIManager();
            }

            return _instance;
        }

        private UIManager(){
            _gameController = GameObject.FindWithTag("GameController").GetComponent<GameController>();
            var characteristicsController = _gameController.Player.GetComponent<CharacteristicsController>();

            _canvas = GameObject.FindWithTag("UICanvas").GetComponent<UICanvas>();

            _canvas.EatButton.onClick.AddListener(characteristicsController.OnEatButtonClicked);
            _canvas.SleepButton.onClick.AddListener(characteristicsController.OnSleepButtonClicked);
            _canvas.WorkButton.onClick.AddListener(characteristicsController.OnWorkButtonClicked);
            _canvas.RelaxButton.onClick.AddListener(characteristicsController.OnRelaxButtonClicked);
            _canvas.CheckEmailButton.onClick.AddListener(characteristicsController.OnCheckEmailButtonClicked);
        }

        public void SetCharacteristicsPanelValue(CharacteristicState state, string value){
            switch (state){
                case CharacteristicState.Eat:
                    _canvas.SetEatPanelText(value);
                    break;
                case CharacteristicState.Sleep:
                    _canvas.SetSleepPanelText(value);
                    break;
                case CharacteristicState.Work:
                    _canvas.SetWorkPanelText(value);
                    break;
                case CharacteristicState.Mood:
                    _canvas.SetMoodPanelText(value);
                    break;
                default:
                    Debug.LogError("Not found CharacteristicState = " + state);
                    break;
            }
        }

    } 
}



