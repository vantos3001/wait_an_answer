using Game;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public Player Player;
    
    void Awake()
    {
        GameTime.InitTime();
    }
}
