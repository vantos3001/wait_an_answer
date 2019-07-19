using Game.Tools;
using UnityEngine;

namespace Game.Dialogue
{
    public class DialogueSystem
    {
        private const string TEXT_ASSET_PATH = "Texts/basic_phrases";
        
        private TextAsset _asset;

        private int _currentPhrase = 0;

        private DialogueSettings _dialogueSettings;

        public void Load(){
            _asset = Resources.Load<TextAsset>(TEXT_ASSET_PATH);
            _dialogueSettings = DialogueSettings.Load(_asset);
        }

        public void StartDialogue(){
            _currentPhrase = 0;
        }

        public void Next(){
            _currentPhrase++;
            var nodeLength = DialogueTextLength();
            
            if ( nodeLength <= _currentPhrase){
                _currentPhrase = nodeLength - 1;
                Debug.LogWarning("Dialogue text ended");
            }
        }

        private int DialogueTextLength(){
            return _dialogueSettings.Nodes.Length;
        }

        public string GetCurrentDialogueText(){
            return _dialogueSettings.Nodes[_currentPhrase].text;
        }
    }
}