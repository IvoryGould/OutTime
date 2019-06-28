using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimatorSwitcher : MonoBehaviour
{
    public int _menuID;
    MainMenuHandler _mainMenuHandler;

    private void Start()
    {
        _mainMenuHandler = GameObject.Find("Canvas").GetComponent<MainMenuHandler>();
    }

    // Update is called once per frame
    public void OnClick()
    {
        _mainMenuHandler.MenuSwitch(_menuID);
    }
}
