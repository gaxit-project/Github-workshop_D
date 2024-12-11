using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountDownTimer : MonoBehaviour
{

    public Text timerText;

    [Header("制限時間")]
    public float timer;
    void Update()
    {
        timer -= Time.deltaTime;
        // timerの表示の切り替え
        timerText.text = "Time : " + timer.ToString("F0");
    }
}
