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

        //�f�o�b�O�p
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
        PlayerPrefs.SetFloat("SEVolume", seVolume); // �ۑ�
        PlayerPrefs.Save();
    }
    public void OnBGMVolumeChange()
    {
        audioSorceBGM.volume = bgmSlider.value;
        PlayerPrefs.SetFloat("BGMVolume", bgmVolume); // �ۑ�
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

    public void PlaySound(int index) //SE�Đ�
    {
        audioSorceSE.PlayOneShot(seLists[index]);
    }

    public void PlayBGM(int index) //BGM�Đ�
    {
        audioSorceBGM.clip = bgmLists[index];
        audioSorceBGM.Play();
    }

    public void StopBGM() //BGM��~
    {
        audioSorceBGM.Stop();
    }

}
