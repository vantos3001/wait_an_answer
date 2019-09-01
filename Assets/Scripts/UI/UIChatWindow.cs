using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Game.UI
{
    public class UIChatWindow : MonoBehaviour
    {
        [SerializeField] private Panel _namePanel;

        [SerializeField] private Image _background;

        [SerializeField] private GameObject _messagesGO;
        
        // Start is called before the first frame update
        void Start()
        {
        
        }

        // Update is called once per frame
        void Update()
        {
        
        }
    }

    public class UIChatElement : MonoBehaviour
    {
        
    }

}


