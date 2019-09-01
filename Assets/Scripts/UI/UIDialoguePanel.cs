using System.Collections.Generic;
using Game.Dialogue;
using UnityEngine;
using UnityEngine.UI;

namespace Game.UI
{
    public class UIDialoguePanel : MonoBehaviour
    {
        [SerializeField] private Panel _textPanel;
        [SerializeField] private Image _backgroind;
        
        [SerializeField] private List<UIAnswerButton> _answerButtons;
        [SerializeField] private Button _nextButton;
    
        // Start is called before the first frame update
        void Awake(){
            var dialogueManager = DialogueManager.Instance();
            dialogueManager.DialoguePhraseChanged += UpdatePanel;
            _nextButton.onClick.AddListener(dialogueManager.NextDialoguePhrase);
        }

        private void UpdatePanel(DialogueNode dialogueNode){
            _textPanel.SetText(dialogueNode.GetDialogueText());
            
            UpdateButtons(dialogueNode);
        }

        private void UpdateButtons(DialogueNode dialogueNode){
            if (dialogueNode.IsHasAnswers()){
                _nextButton.gameObject.SetActive(false);
                
                var answerCount = dialogueNode.AnswerCount();
                for (int i = 0; i < answerCount; i++){
                    var currentAnswerButton = _answerButtons[answerCount];
                    currentAnswerButton.SetActive(true);
                    currentAnswerButton.SetText(dialogueNode.GetAnswerTextById(i));
                }
            }
            else{
                _nextButton.gameObject.SetActive(true);
                foreach (var answerButton in _answerButtons){
                    answerButton.SetActive(false);
                }
            }
        }
    }
}


