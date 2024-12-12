using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class soundSCP : MonoBehaviour
{

    public void soundBotton()
    {
        SoundManager.GetInstance().PlaySound(0);
    }
}
