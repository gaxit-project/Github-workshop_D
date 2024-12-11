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

    [Header("��������")]
    public float timer;

    [Header("�N���A���C��")]
    public int clearScore;

    private void Start()
    {
        isClear = false;
    }
    void Update()
    {
        
        timer -= Time.deltaTime;
        // timer�̕\���̐؂�ւ�
        timerText.text = "Timer : " + timer.ToString("F0");

        if(timer <= 0)
        {
            if (sumSCP.sum >= clearScore)
            {
                Debug.Log("�Q�[���N���A");
                isClear = true;
            }
            else
            {
                Debug.Log("�Q�[���I�[�o�[");
            }
            UnityEngine.SceneManagement.SceneManager.LoadScene("Result");

        }

    }
}
