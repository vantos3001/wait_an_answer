using Game.UI;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public Player Player;

    public UIManager _uiManager;
    
    // Start is called before the first frame update
    void Start()
    {
        _uiManager = UIManager.Instance();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
