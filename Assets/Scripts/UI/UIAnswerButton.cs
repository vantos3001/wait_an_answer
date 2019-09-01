using UnityEngine;
using UnityEngine.UI;

namespace Game.UI
{
    public class UIAnswerButton : MonoBehaviour
    {
        [SerializeField] private Button _button;

        [SerializeField] private Text _text;

        public void SetText(string text){
            _text.text = text;
        }

        public void SetActive(bool isActive){
            _button.gameObject.SetActive(isActive);
        }
    }
}