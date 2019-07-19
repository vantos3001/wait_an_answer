using System;
using Game.Tools;
using UnityEngine;

namespace Game.Dialogue
{
    public static class DialogueSystem
    {
        private static TextAsset _asset;

        private static int _currentPhrase = 0;

        private static DialogueSettings _dialogueSettings;

        public static Action<string> DialogueTextChanged;

        public static void Load(){
            _asset = Resources.Load<TextAsset>("Texts/basic_phrases");
            _dialogueSettings = DialogueSettings.Load(_asset);
        }

        public static void StartDialogue(){
            _currentPhrase = 0;
            DialogueTextChanged?.Invoke(_dialogueSettings.Nodes[_currentPhrase].text);
        }

        public static void Next(){
            _currentPhrase++;
            var nodeLength = _dialogueSettings.Nodes.Length;
            if (_currentPhrase < nodeLength){
                DialogueTextChanged?.Invoke(_dialogueSettings.Nodes[_currentPhrase].text);
            }
        }
    }
}