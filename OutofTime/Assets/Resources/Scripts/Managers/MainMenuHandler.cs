using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
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

    private int _menuID;
    private bool _onSplash = true;

    private void Start()
    {
        _onSplash = true;

        _titleScreen = GameObject.Find("TitleScreen");

        _mainTitle = GameObject.Find("TableTitle");
        _mainMenu = GameObject.Find("TableMainMenu");
        _mainLeaderboard = GameObject.Find("TableLeaderboard");
        _mainOptions = GameObject.Find("TableOptions");
        _mainCredits = GameObject.Find("TableCredits");
        _mainLeaveGame = GameObject.Find("TableLeaveGame");

        _mainLevelSelect = GameObject.Find("TableLevelSelect");
        _mainLevelPreview = GameObject.Find("TableLevelSelect");

        

        // Grabs Animator from GameObject
        _menuID = 0;
        HideAll();
        _titleScreen.SetActive(true);
        //AnimatorSwitch(_menuID);
    }

    public void Update()
    {
        
        if (Input.anyKey && _onSplash == true)
        {
            _onSplash = false;
            HideAll();
            _mainTitle.SetActive(true);
            _mainMenu.SetActive(true);
        }
    }
    /*
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
    */

    public void MenuSwitch(int _menuID)
    {
        switch (_menuID)
        {
            case 0: //Title

                HideAll();
                _titleScreen.SetActive(true);

                break;

            case 1: // start game
                SceneManager.LoadScene("Level01");
                break;

            case 2: // leaderboard
                HideAll();
                _mainMenu.SetActive(true);
                _mainLeaderboard.SetActive(true);
                break;

            case 3: // options
                HideAll();
                _mainMenu.SetActive(true);
                _mainOptions.SetActive(true);
                break;

            case 4: // credits
                HideAll();
                _mainMenu.SetActive(true);
                _mainCredits.SetActive(true);
                break;

            case 5: // end game
                Quit();
                break;
        }
    }
    public void HideAll()
    {
        // Sets the Titlescreen, turns everything else off
        _titleScreen.SetActive(false);
        _mainTitle.SetActive(false);
        _mainMenu.SetActive(false);
        _mainLeaderboard.SetActive(false);
        _mainCredits.SetActive(false);
        
    }

    public void Quit()
    {
        //If we are running in a standalone build of the game
#if UNITY_STANDALONE
        //Quit the application
        Application.Quit();
#endif

        //If we are running in the editor
#if UNITY_EDITOR
        //Stop playing the scene
        UnityEditor.EditorApplication.isPlaying = false;
#endif
    }
}
