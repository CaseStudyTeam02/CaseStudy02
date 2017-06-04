using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleToGame : MonoBehaviour {

    ////    初期化処理
    ////////////////////////////////////////////////////////////////
    void Start ()
    {

    }

    ////    更新処理
    ////////////////////////////////////////////////////////////////
    void Update ()
    {
    }

    ////    オブジェクトタップ時処理
    ////////////////////////////////////////////////////////////////
    public void ToGame()
    {
        SceneManager.LoadScene("Game");
    }
}

