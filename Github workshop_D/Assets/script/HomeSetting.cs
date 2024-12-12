using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Assertions;

public class HomeSetting : MonoBehaviour
{
    [Header("�e��{�^��")]
    public GameObject settingButton;
    public GameObject backButton;

    [Header("�z�[���Ɛݒ���")]
    public GameObject titleHome;
    public GameObject titleSetting;

    public static bool isHome;

    void Start()
    {
        isHome = false;
        GameSetting();

        if (settingButton != null)
        {
            ButtonRegistration(settingButton);
        }
        if (backButton != null)
        {
            ButtonRegistration(backButton);
        }
    }

    private void Update()
    {
        Debug.Log(isHome);
    }

    //�o�^�����֐� OnClick�Ɠ���

    void GameSetting()
    {
        titleHome.SetActive(!isHome);
        titleSetting.SetActive(isHome);
        isHome = !isHome;
    }

    // button��o�^����֐�
    void ButtonRegistration(GameObject _buttonObj)
    {
        //IsNotNull��null�łȂ������m�F����(null�ł���΃G���[���o��)
        Assert.IsNotNull(_buttonObj, "_button��null�ł��I");

        Button button = _buttonObj.GetComponent<Button>();

        if (_buttonObj.name == settingButton.name)
        {
            button.onClick.AddListener(GameSetting);
        }
        else if (_buttonObj.name == backButton.name)
        {
            button.onClick.AddListener(GameSetting);
        }
    }
}
