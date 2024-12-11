using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Clear : MonoBehaviour
{
    public TextMeshProUGUI text;
    void Start()
    {
        if(CountDownTimer.isClear = true;)
        {
           text.text  = "ゲームクリア！";
        }
        else
        {
            text.text = "ゲームオーバー";
        }
    }
    

    
}
