using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Nextscenescript : MonoBehaviour
{
    public void LoadScene(string main)
    {
        SceneManager.LoadScene(main);
    }
}
