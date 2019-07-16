

using System;
using System.Collections.Generic;
using Game.UI;
using UnityEditorInternal;
using UnityEngine;

namespace Game
{
    public enum CharacteristicState
    {
        Eat,
        Sleep,
        Mood,
        Work,
    }
    
    public class CharacteristicsController : MonoBehaviour
    {
        private const int DEFAULT_STAT_VALUE = 100;
        
        private readonly List<CharacteristicData> _characteristics = new
            List<CharacteristicData>();

        private void Start(){
            var eat = new CharacteristicData(CharacteristicState.Eat, DEFAULT_STAT_VALUE);
            _characteristics.Add(eat);
            
            var sleep = new CharacteristicData(CharacteristicState.Sleep, DEFAULT_STAT_VALUE);
            _characteristics.Add(sleep);
            
            var mood = new CharacteristicData(CharacteristicState.Mood, DEFAULT_STAT_VALUE);
            _characteristics.Add(mood);
            
            var work = new CharacteristicData(CharacteristicState.Work, DEFAULT_STAT_VALUE);
            _characteristics.Add(work);
        }

        private CharacteristicData FindCharacteristicData(CharacteristicState state){
            foreach (var data in _characteristics){
                if (data.State == state){
                    return data;
                }
            }
            
            throw new Exception("CharacteristicState = " + state + " is not found");
        }

        private void ReduceCharacteristicValue(CharacteristicState state, int value){
            var data = FindCharacteristicData(state);
            data.ChangeValue(-value);
        }

        private void IncreaseCharacteristicValue(CharacteristicState state, int value){
            var data = FindCharacteristicData(state);
            data.ChangeValue(value);
        }

        public void OnEatButtonClicked(){
            Debug.Log("EAT");
            UIManager.Instance().SetCharacteristicsPanelValue(CharacteristicState.Eat, "5");
        }

        public void OnSleepButtonClicked(){
            Debug.Log("SLEEP");
            UIManager.Instance().SetCharacteristicsPanelValue(CharacteristicState.Sleep, "10");
        }

        public void OnWorkButtonClicked(){
            Debug.Log("WORK");
            UIManager.Instance().SetCharacteristicsPanelValue(CharacteristicState.Work, "15");
        }

        public void OnRelaxButtonClicked(){
            Debug.Log("RELAX");
            UIManager.Instance().SetCharacteristicsPanelValue(CharacteristicState.Mood, "20");
        }

        public void OnCheckEmailButtonClicked(){
            Debug.Log("CHECK EMAIL");
        }
    }

    public class CharacteristicData
    {
        private int _value;

        public CharacteristicState State{ get;}

        public CharacteristicData(CharacteristicState state, int value){
            State = state;
            _value = value;
        }

        public void ChangeValue(int value){
            //TODO: do not decrease below zero and do not increase above max value
            _value += value;
        }
    }
}