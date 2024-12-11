using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Nextscenescript : MonoBehaviour
{
    public void LoadScene()
    {
        SceneManager.LoadScene("main");
    }
}
