using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class DialogueControl : MonoBehaviour
{
    [SerializeField]
    public TextMeshProUGUI dialogueBox;
    private string intro1;
    private string intro2;
    private string intro3;
    private string intro4;
    public string clear;
    public string end1;
    private string end2;
    private string end3;
    // Start is called before the first frame update
    void Start()
    {
        intro1 = "If I can just get to the top of the is clock, I'll be able to control time indefinitely.";
        intro2 = "Unfortunately I can only get in through the bird for the next 90 seconds.";
        intro3 = "Thankfully, the clock has enough power that some of it spills out.";
        intro4 = "If I want into the spots where the clock's power is leaking to, it might buy me enough time to get in...";
        end1 = "I made it! And just in time too!";
        end2 = "Now I can finally control time!";
        end3 = "I can sleep forever and never lose the time that I need to do the things I need to do!";
        clear = " ";
        dialogueBox.text = intro1;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1") && dialogueBox.text == intro4)
        {
            dialogueBox.text = clear;
        }
        if (Input.GetButtonDown("Fire1") && dialogueBox.text == intro3)
        {
            dialogueBox.text = intro4;
        }
        if (Input.GetButtonDown("Fire1") && dialogueBox.text == intro2)
        {
            dialogueBox.text = intro3;
        }
        if (Input.GetButtonDown("Fire1") && dialogueBox.text == intro1)
        {
            dialogueBox.text = intro2;
        }
        if (Input.GetButtonDown("Fire1") && dialogueBox.text == end3)
        {
            SceneManager.LoadScene(0);
        }
        if (Input.GetButtonDown("Fire1") && dialogueBox.text == end2)
        {
            dialogueBox.text = end3;
        }
        if (Input.GetButtonDown("Fire1") && dialogueBox.text == end1)
        {
            dialogueBox.text = end2;
        }
    }
    
}
