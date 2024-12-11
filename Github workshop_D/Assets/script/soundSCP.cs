using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class soundSCP : MonoBehaviour
{
    public AudioClip countSound;
    AudioSource audiosource;
    // Start is called before the first frame update
    void Start()
    {
        audiosource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void soundBotton()
    {
        SoundManager.GetInstance().PlaySound(0);
    }
}
