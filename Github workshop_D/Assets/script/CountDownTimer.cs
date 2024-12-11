using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CountDownTimer : MonoBehaviour
{

    public TextMeshProUGUI timerText;

    [Header("制限時間")]
    public float timer;
    void Update()
    {
        
        timer -= Time.deltaTime;
        // timerの表示の切り替え
        timerText.text = timer.ToString("F0");

        if(timer <= 0)
        {
        #if UNITY_EDITOR //unity内でゲーム時
                    UnityEditor.EditorApplication.isPlaying = false;
        #else //ビルドされたゲームの時
                    Application.Quit();
        #endif
        }

    }
}
