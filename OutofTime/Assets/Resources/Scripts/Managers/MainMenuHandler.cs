using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class MainMenuHandler : MonoBehaviour
{
    // Title
    private GameObject _titleScreen;

    // Main Menu Components
    private GameObject _mainTitle, _mainMenu, _mainLeaderboard, _mainOptions, _mainCredits, _mainLeaveGame;

    // Level Sub menu
    private GameObject _mainLevelSelect, _mainLevelPreview;

    // Animator switcher Vars
    [SerializeField]
    private Animator _animator01, _animator02, _menuID;

    private void Start()
    {
        _titleScreen = GameObject.Find("TitleScreen");

        _mainTitle = GameObject.Find("TableTitle");
        _mainMenu = GameObject.Find("TableMainMenu");
        _mainLeaderboard= GameObject.Find("TableLeaderboard");
        _mainOptions = GameObject.Find("TableOptions");
        _mainCredits = GameObject.Find("TableCredits");
        _mainLeaveGame = GameObject.Find("TableLeaveGame");

        _mainLevelSelect = GameObject.Find("TableLevelSelect");
        _mainLevelPreview = GameObject.Find("TableLevelSelect");

        // Sets the Titlescreen, turns everything else off
        _titleScreen.SetActive(true);
        _mainTitle.SetActive(false);
        _mainMenu.SetActive(false);
        _mainLeaderboard.SetActive(false);
        _mainOptions.SetActive(false);
        _mainCredits.SetActive(false);
        _mainLeaveGame.SetActive(false);
        _mainLevelSelect.SetActive(false);
        _mainLevelPreview.SetActive(false);

        // Grabs Animator from GameObject
        _menuID = null;
        AnimatorSwitch(_menuID);
    }

    // Animator Logic Gate + Animator
    public void AnimatorSwitch(Animator _menuAnimator)
    {
        // when game starts, animator01 loads TitleScreen
        if (_animator01 == null)    
        {
            _animator01 = GameObject.Find("TitleScreen").GetComponent<Animator>();
        }
        else if (_menuAnimator == _animator01)
        {

        }            
        else
        {
            _animator02 = _animator01;                          // moves 'tor01 to 'tor02
            _animator01 = _menuAnimator;

            // fires corresponding anims
            _animator01.SetTrigger("open");
            _animator02.SetTrigger("close");
        }        
    }

}
