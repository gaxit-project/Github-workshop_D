using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class CountDownTimer : MonoBehaviour
{

    public TextMeshProUGUI timerText;

    public static bool isClear;

    [Header("制限時間")]
    public float timer;

    [Header("クリアライン")]
    public int clearScore;

    private void Start()
    {
        isClear = false;
    }
    void Update()
    {
        
        timer -= Time.deltaTime;
        // timerの表示の切り替え
        timerText.text = "Timer : " + timer.ToString("F0");

        if(timer <= 0)
        {
            if (sumSCP.sum >= clearScore)
            {
                Debug.Log("ゲームクリア");
                isClear = true;
            }
            else
            {
                Debug.Log("ゲームオーバー");
            }
            UnityEngine.SceneManagement.SceneManager.LoadScene("Result");

        }

    }
}
