using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountDownTimer : MonoBehaviour
{

    public Text timerText;

    [Header("��������")]
    public float timer;
    void Update()
    {
        timer -= Time.deltaTime;
        // timer�̕\���̐؂�ւ�
        timerText.text = "Time : " + timer.ToString("F0");
    }
}
