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
        
        [SerializeField] private List<Button> _answerButtons;
        [SerializeField] private Button _nextButton;
    
        // Start is called before the first frame update
        void Awake(){
            var dialogueManager = DialogueManager.Instance();
            dialogueManager.DialogueTextChanged += _textPanel.SetText;
            _nextButton.onClick.AddListener(dialogueManager.NextDialoguePhrase);
        }

        // Update is called once per frame
        void Update()
        {
        
        }
    }
}


