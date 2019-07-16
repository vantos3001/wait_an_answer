using System.Collections;
using System.Collections.Generic;
using Game;
using UnityEngine;

public class Player : MonoBehaviour
{
    private CharacteristicsController _characteristicsController;
    
    // Start is called before the first frame update
    private void Awake(){
        _characteristicsController = GetComponent<CharacteristicsController>();

    }
}
