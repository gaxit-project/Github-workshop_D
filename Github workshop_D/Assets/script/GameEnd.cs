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
         * ����̓v���v���Z�b�T�Ńr���h���ɂ͑Ή����Ă�����݂̂��R���p�C�������
        */
    #if UNITY_EDITOR //unity���ŃQ�[����
            UnityEditor.EditorApplication.isPlaying = false;
    #else //�r���h���ꂽ�Q�[���̎�
                        Application.Quit();
    #endif
    }
}
