using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class sumSCP : MonoBehaviour
{
    public static int sum;
    public TextMeshProUGUI count;

    public int scoreSpan;

    public CountDownTimer countDownTimer;
    // Start is called before the first frame update
    void Start()
    {
        sum = 0;
    }

    // Update is called once per frame
    void Update()
    {
        count.text = sum.ToString();

 

    }
    public void sumBotton()
    {
        if(countDownTimer != null && countDownTimer.timer > 0)
        {
            sum++;
            if (sum != 0 && sum % scoreSpan == 0)
            {
                SoundManager.GetInstance().PlaySound(1);
            }
        }
    }
}
