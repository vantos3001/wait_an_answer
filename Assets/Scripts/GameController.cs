using Game;
using Game.UI;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public Player Player;
    public GameTime _GameTime;
    
    void Awake()
    {
        _GameTime = new GameTime();
    }
}
