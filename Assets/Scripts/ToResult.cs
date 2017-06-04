using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ToResult : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    ////    オブジェクトタップ時処理
    ////////////////////////////////////////////////////////////////
    public void TransitionToResult()
    {
        SceneManager.LoadScene("Result");
    }
}
