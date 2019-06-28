using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UITime : MonoBehaviour
{

    [SerializeField]
    private TextMeshProUGUI timeText;
    private string timeStep;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timeStep = Time.time.ToString("#.00");
        timeText.text = timeStep;
    }
}
