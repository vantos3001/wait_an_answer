

using System;
using System.Collections.Generic;
using Game.UI;
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
        private const int DEFAULT_STAT_VALUE = 50;
        
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
            
            UpdateCharacteristicsPanels();
        }

        private CharacteristicData FindCharacteristicData(CharacteristicState state){
            foreach (var data in _characteristics){
                if (data.State == state){
                    return data;
                }
            }
            
            throw new Exception("CharacteristicState = " + state + " is not found");
        }

        private void ChangeCharacteristicValue(CharacteristicState state, int value){
            var data = FindCharacteristicData(state);
            data.ChangeValue(value);
        }

        public void OnEatButtonClicked(){
            Debug.Log("EAT");
            ChangeAllCharacteristicsOnValue(CharacteristicConstants.EATING_DELTA_EAT, CharacteristicConstants.EATING_DELTA_SLEEP,
                CharacteristicConstants.EATING_DELTA_WORK, CharacteristicConstants.EATING_DELTA_MOOD);
            
            GameTime.AddTime(CharacteristicConstants.EATING_TIME_IN_HOURS, 0);
            
            UpdateCharacteristicsPanels();
            
        }

        public void OnSleepButtonClicked(){
            Debug.Log("SLEEP");
            ChangeAllCharacteristicsOnValue(CharacteristicConstants.SLEEPING_DELTA_EAT, CharacteristicConstants.SLEEPING_DELTA_SLEEP,
                CharacteristicConstants.SLEEPING_DELTA_WORK, CharacteristicConstants.SLEEPING_DELTA_MOOD);
            
            GameTime.AddTime(CharacteristicConstants.SLEEPING_TIME_IN_HOURS, 0);
            
            UpdateCharacteristicsPanels();
        }

        public void OnWorkButtonClicked(){
            Debug.Log("WORK");
            ChangeAllCharacteristicsOnValue(CharacteristicConstants.WORKING_DELTA_EAT, CharacteristicConstants.WORKING_DELTA_SLEEP,
                CharacteristicConstants.WORKING_DELTA_WORK, CharacteristicConstants.WORKING_DELTA_MOOD);

            GameTime.AddTime(CharacteristicConstants.WORKING_TIME_IN_HOURS, 0);
            
            UpdateCharacteristicsPanels();
        }

        public void OnRelaxButtonClicked(){
            Debug.Log("RELAX");
            ChangeAllCharacteristicsOnValue(CharacteristicConstants.RELAXING_DELTA_EAT, CharacteristicConstants.RELAXING_DELTA_SLEEP,
                CharacteristicConstants.RELAXING_DELTA_WORK, CharacteristicConstants.RELAXING_DELTA_MOOD);
            
            GameTime.AddTime(CharacteristicConstants.RELAXING_TIME_IN_HOURS, 0);
            
            UpdateCharacteristicsPanels();
        }

        public void OnCheckEmailButtonClicked(){
        }

        private void ChangeAllCharacteristicsOnValue(int eat, int sleep, int work, int mood){
            ChangeCharacteristicValue(CharacteristicState.Eat, eat);
            ChangeCharacteristicValue(CharacteristicState.Sleep, sleep);
            ChangeCharacteristicValue(CharacteristicState.Work, work);
            ChangeCharacteristicValue(CharacteristicState.Mood, mood);
        }
        
        private void UpdateCharacteristicsPanels(){
            var uiManager = UIManager.Instance();
            var eat = FindCharacteristicData(CharacteristicState.Eat);
            uiManager.SetCharacteristicsPanelValue(CharacteristicState.Eat, eat.GetValue());
            
            var sleep = FindCharacteristicData(CharacteristicState.Sleep);
            uiManager.SetCharacteristicsPanelValue(CharacteristicState.Sleep, sleep.GetValue());
            
            var work = FindCharacteristicData(CharacteristicState.Work);
            uiManager.SetCharacteristicsPanelValue(CharacteristicState.Work, work.GetValue());
            
            var mood = FindCharacteristicData(CharacteristicState.Mood);
            uiManager.SetCharacteristicsPanelValue(CharacteristicState.Mood, mood.GetValue());
        }
    }

    public class CharacteristicData
    {
        private const int MAX_STAT_VALUE = 100;
        private const int MIN_STAT_VALUE = 0;
        
        private int _value;

        public CharacteristicState State{ get;}

        public CharacteristicData(CharacteristicState state, int value){
            State = state;
            _value = value;
        }

        public int GetValue(){
            return _value;
        }

        public void ChangeValue(int value){
            _value += value;

            if (_value > MAX_STAT_VALUE){
                _value = MAX_STAT_VALUE;
            }

            if (_value < MIN_STAT_VALUE){
                _value = MIN_STAT_VALUE;
            }
        }
    }
}