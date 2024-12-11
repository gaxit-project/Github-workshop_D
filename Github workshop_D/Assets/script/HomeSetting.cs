using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Assertions;

public class HomeSetting : MonoBehaviour
{
    [Header("各種ボタン")]
    public GameObject settingButton;
    public GameObject backButton;

    [Header("ホームと設定画面")]
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

    //登録される関数 OnClickと同じ

    void GameSetting()
    {
        titleHome.SetActive(!isHome);
        titleSetting.SetActive(isHome);
        isHome = !isHome;
    }

    // buttonを登録する関数
    void ButtonRegistration(GameObject _buttonObj)
    {
        //IsNotNullはnullでない事を確認する(nullであればエラーを出す)
        Assert.IsNotNull(_buttonObj, "_buttonはnullです！");

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
