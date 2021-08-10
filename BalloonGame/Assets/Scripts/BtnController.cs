using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class BtnController : MonoBehaviour
{

    public Button btnPlay;
    public string sceneName;


    // Start is called before the first frame update
    void Start()
    {
        btnPlay.onClick.AddListener(PlayGame);
    }

    private void PlayGame()
    {
        Debug.Log("Play Button Clicked");
        SceneManager.LoadScene(sceneName);
    }
}
