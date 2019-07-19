using Game;
using Game.Dialogue;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public Player Player;
    
    void Awake()
    {
        GameTime.InitTime();

        LoadManager.Instance().LoadFinished += OnLoadFinished;
        LoadManager.Instance().Load();
    }

    private void OnLoadFinished(){
        DialogueSystem.StartDialogue();
    }
}
