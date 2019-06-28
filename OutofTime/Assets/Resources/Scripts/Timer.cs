using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Timer : MonoBehaviour
{

    public float time;

    [SerializeField]
    private TextMeshProUGUI timerText;

    [SerializeField]
    private GameObject Player;

    // Start is called before the first frame update
    void Start()
    {

        timerText.text = time.ToString("#.00");

        StartCoroutine(TimerWait());

    }

    // Update is called once per frame
    void Update()
    {

        timerText.text = time.ToString("#.00");

        if (time == 0) {

            

        }

    }

    IEnumerator TimerWait() {

        while (time != 0) {

            yield return new WaitForSecondsRealtime(0.01f);
            time -= 0.01f;

            timerText.text = time.ToString("#.00");

        }

    }

}
