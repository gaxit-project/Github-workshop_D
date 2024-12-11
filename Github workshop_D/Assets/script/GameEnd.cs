using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameEnd : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void EndGame() //Quit
    {
        /*
         * これはプリプロセッサでビルド時には対応している方のみがコンパイルされる
        */
    #if UNITY_EDITOR //unity内でゲーム時
            UnityEditor.EditorApplication.isPlaying = false;
    #else //ビルドされたゲームの時
                        Application.Quit();
    #endif
    }
}
