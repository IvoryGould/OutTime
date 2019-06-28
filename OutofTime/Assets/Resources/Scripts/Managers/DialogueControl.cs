using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DialogueControl : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI dialogueBox;
    private string intro1;
    private string intro2;
    private string intro3;
    private string intro4;
    private string clear;
    // Start is called before the first frame update
    void Start()
    {
        intro1 = "If I can just get to the top of the is clock, I'll be able to control time indefinitely.";
        intro2 = "Unfortunately I can only get in through the bird for the next 90 seconds.";
        intro3 = "Thankfully, the clock has enough power that some of it spills out.";
        intro4 = "If I want into the spots where the clock's power is leaking to, it might buy me enough time to get in...";
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
    }
}