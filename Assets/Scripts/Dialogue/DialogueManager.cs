using System;

namespace Game.Dialogue
{
    public class DialogueManager
    {
        private static DialogueManager _manager;
        private DialogueSystem _dialogueSystem;
        
        public Action<string> DialogueTextChanged;

        
        private DialogueManager(){
            _dialogueSystem = new DialogueSystem();
        }
        
        public void StartDialogue(){
            _dialogueSystem.StartDialogue();

            NotifyDialogueTextChanged();
        }

        public void NextDialoguePhrase(){
            _dialogueSystem.Next();
            
            NotifyDialogueTextChanged();
        }

        private void NotifyDialogueTextChanged(){
            var currentDialogueText = _dialogueSystem.GetCurrentDialogueText();
            DialogueTextChanged?.Invoke(currentDialogueText);
        }
        
        public void Load(){
            _dialogueSystem.Load();
        }
        
        public static DialogueManager Instance(){
            if (_manager == null){
                _manager = new DialogueManager();
            }

            return _manager;
        }
    }
}