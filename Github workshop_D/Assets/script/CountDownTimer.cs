using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountDownTimer : MonoBehaviour
{

    public Text timerText;

    [Header("§ŒÀŠÔ")]
    public float timer;
    void Update()
    {
        timer -= Time.deltaTime;
        // timer‚Ì•\¦‚ÌØ‚è‘Ö‚¦
        timerText.text = "Time : " + timer.ToString("F0");
    }
}
