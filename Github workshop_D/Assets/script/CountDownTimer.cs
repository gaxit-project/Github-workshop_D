using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CountDownTimer : MonoBehaviour
{

    public TextMeshProUGUI timerText;

    [Header("��������")]
    public float timer;
    void Update()
    {
        
        timer -= Time.deltaTime;
        // timer�̕\���̐؂�ւ�
        timerText.text = timer.ToString("F0");

        if(timer <= 0)
        {
        #if UNITY_EDITOR //unity���ŃQ�[����
                    UnityEditor.EditorApplication.isPlaying = false;
        #else //�r���h���ꂽ�Q�[���̎�
                    Application.Quit();
        #endif
        }

    }
}
