using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class SoundManager : MonoBehaviour
{
    public static SoundManager Instance = null;

    bool ishome = true;

    public static SoundManager GetInstance()
    {
        if (Instance == null)
        {
            Instance = FindObjectOfType<SoundManager>();
        }
        return Instance;
    }

    [SerializeField] AudioClip[] seLists;
    [SerializeField] AudioClip[] bgmLists;
    public Slider seSlider;
    public Slider bgmSlider;
    [SerializeField] AudioSource audioSorceSE;
    [SerializeField] AudioSource audioSorceBGM;
    float seVolume;
    float bgmVolume;
    private void Awake()
    {
        if (this != GetInstance())
        {
            Destroy(this.gameObject);
            return;
        }
        DontDestroyOnLoad(this.gameObject);
    }
    private void Start()
    {
        if (seSlider != null && bgmSlider != null)
        {
            seSlider.onValueChanged.AddListener(delegate { OnSEVolumeChange(); });
            bgmSlider.onValueChanged.AddListener(delegate { OnBGMVolumeChange(); });

        }
        PlayBGM(0);
    }


    private void Update()
    {

        //デバッグ用
        if (Input.GetKeyDown("o"))
        {
            ishome = !ishome;
        }

        Debug.Log(ishome);



        if (!ishome)
        {
            if (seSlider == null && bgmSlider == null)
            {
                seSlider = GameObject.Find("Canvas/Slider1").GetComponent<Slider>();
                bgmSlider = GameObject.Find("Canvas/Slider2").GetComponent<Slider>();
                seSlider.onValueChanged.AddListener(delegate { OnSEVolumeChange(); });
                bgmSlider.onValueChanged.AddListener(delegate { OnBGMVolumeChange(); });
            }
            seSlider.value = SEVolume;
            bgmSlider.value = BGMVolume;
        }

    }
    public void OnSEVolumeChange()
    {
        audioSorceSE.volume = seSlider.value;
        PlayerPrefs.SetFloat("SEVolume", seVolume); // 保存
        PlayerPrefs.Save();
    }
    public void OnBGMVolumeChange()
    {
        audioSorceBGM.volume = bgmSlider.value;
        PlayerPrefs.SetFloat("BGMVolume", bgmVolume); // 保存
        PlayerPrefs.Save();
    }
    public float BGMVolume //BGM {     [  
    {
        get { return audioSorceBGM.volume; }
        set { audioSorceBGM.volume = value; }
    }

    public float SEVolume //SE {     [  
    {
        get { return audioSorceSE.volume; }
        set { audioSorceSE.volume = value; }
    }

    public void PlaySound(int index) //SE再生
    {
        audioSorceSE.PlayOneShot(seLists[index]);
    }

    public void PlayBGM(int index) //BGM再生
    {
        audioSorceBGM.clip = bgmLists[index];
        audioSorceBGM.Play();
    }

    public void StopBGM() //BGM停止
    {
        audioSorceBGM.Stop();
    }

}
