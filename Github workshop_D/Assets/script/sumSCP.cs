using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class sumSCP : MonoBehaviour
{
    public int sum;
    public TextMeshProUGUI count;
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
        sum++;
    }
}
