using System.Collections;
using System.Collections.Generic;
using Game;
using UnityEngine;

public class Player : MonoBehaviour
{
    private CharacteristicsController _characteristicsController;
    
    // Start is called before the first frame update
    void Start(){
        _characteristicsController = GetComponent<CharacteristicsController>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
