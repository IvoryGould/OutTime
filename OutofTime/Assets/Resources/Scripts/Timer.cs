using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{

    public int time;

    [SerializeField]
    private Text timerText;

    [SerializeField]
    private GameObject Player;

    // Start is called before the first frame update
    void Start()
    {

        timerText.text = time.ToString();

        StartCoroutine(TimerWait());

    }

    // Update is called once per frame
    void Update()
    {

        timerText.text = time.ToString();

        if (time == 0) {

            

        }

    }

    IEnumerator TimerWait() {

        while (time != 0) {

            yield return new WaitForSecondsRealtime(1);
            time -= 1;

            timerText.text = time.ToString();

        }

    }

}
