using UnityEngine;

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

            var time = _gameController._GameTime;
            var clock = _canvas.Clock;
            
            clock.UpdateTime(time.ClockToString());
            time.OnTimeChanged += clock.UpdateTime;
        }
        
        public void SetCharacteristicsPanelValue(CharacteristicState state, int value){
            string text = value.ToString();
            switch (state){
                case CharacteristicState.Eat:
                    _canvas.SetEatPanelText(text);
                    break;
                case CharacteristicState.Sleep:
                    _canvas.SetSleepPanelText(text);
                    break;
                case CharacteristicState.Work:
                    _canvas.SetWorkPanelText(text);
                    break;
                case CharacteristicState.Mood:
                    _canvas.SetMoodPanelText(text);
                    break;
                default:
                    Debug.LogError("Not found CharacteristicState = " + state);
                    break;
            }
        }
    } 
}



