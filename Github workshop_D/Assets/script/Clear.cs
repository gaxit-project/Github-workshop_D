using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Clear : MonoBehaviour
{
    public TextMeshProUGUI textResult;
    public TextMeshProUGUI textScore;
    void Start()
    {
        if(CountDownTimer.isClear)
        {
           textResult.text  = "Clear";
            SoundManager.GetInstance().PlaySound(2);
        }
        else
        {
            SoundManager.GetInstance().PlaySound(3);
            textResult.text = "GameOver";
        }

        textScore.text = "Score " + sumSCP.sum.ToString();
    }
    

    
}
