using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimatorSwitcher : MonoBehaviour
{
    private Animator _menuAnimator;
    MainMenuHandler _mainMenuHandler;

    private void Awake()
    {
        _mainMenuHandler = GameObject.Find("Canvas").GetComponent<MainMenuHandler>();
    }

    private void Start()
    {
        _menuAnimator = gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    private void OnMouseEnter()
    {
        
        _mainMenuHandler.AnimatorSwitch(_menuAnimator);
    }
}
