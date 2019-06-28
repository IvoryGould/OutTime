using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DialogueControl : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI dialogueBox;
    private string intro1;
    private string clear;
    // Start is called before the first frame update
    void Start()
    {
        intro1 = "This is the first string.";
        clear = " ";
    }

    // Update is called once per frame
    void Update()
    {
        dialogueBox.text = clear;
    }
}
