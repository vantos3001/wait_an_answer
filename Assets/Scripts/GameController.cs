using Game.UI;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public Player Player;

    public UIManager _uiManager;
    
    void Awake()
    {
        _uiManager = UIManager.Instance();
    }
}
