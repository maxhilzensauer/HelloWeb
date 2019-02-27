using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SceneSwitcher : MonoBehaviour {
    public void LoadMainScene()
    {
        SceneManager.LoadScene("SampleScene");
    }
    public void LoadScene2()
    {
        SceneManager.LoadScene("scene2");
    }
}
