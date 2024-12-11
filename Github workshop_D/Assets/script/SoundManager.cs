using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
public class SoundManager : MonoBehaviour
{
    public static SoundManager Instance = null;

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
            seSlider.onValueChanged.AddListener(delegate { OnSEVolumeChange(); });

        }
    }


    private void Update()
    {
        if(seSlider != null &&bgmSlider != null)
        {
            seSlider = GameObject.Find("Canvas/Slider").GetComponent<Slider>();
            bgmSlider=GameObject.Find("Canvas/Slider").GetComponent <Slider>();
            seSlider.onValueChanged.AddListener(delegate { OnSEVolumeChange(); });
            bgmSlider.onValueChanged.AddListener(delegate { OnBGMVolumeChange(); });
            seSlider.value = seVolume;
            bgmSlider.value = bgmVolume;
        }

    }
    public void OnSEVolumeChange()
    {
        audioSorceSE.volume = seSlider.value;
        PlayerPrefs.SetFloat("SEVolume", seVolume); // •Û‘¶
        PlayerPrefs.Save();
    }
    public void OnBGMVolumeChange()
    {
        audioSorceBGM.volume = seSlider.value;
        PlayerPrefs.SetFloat("BGMVolume", bgmVolume); // •Û‘¶
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
}
