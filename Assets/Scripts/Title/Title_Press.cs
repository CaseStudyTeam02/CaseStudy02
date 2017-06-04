﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Title_Press : MonoBehaviour
{
    /**************************************************************************
    *	定数定義
    ***************************************************************************/
    public static readonly int DRAW_TIMER = 30;                      // 雲オブジェクト生成フレーム数

    /**************************************************************************
    *	変数宣言
    ***************************************************************************/
    private int frame = 0;

    /**************************************************************************
    *	初期化処理
    ***************************************************************************/
    void Start()
    {

    }

    /**************************************************************************
   *	更新処理
   ***************************************************************************/
    void Update()
    {
        frame++;

        //30フレーム毎に表示・非表示を繰り返す
        if (frame / DRAW_TIMER % 2 == 0)
        {
            GetComponent<Renderer>().enabled = false;
        }
        else
        {
            GetComponent<Renderer>().enabled = true;
        }

        //--------------------------------------------------------------------------------------------//
        //			画面タップ認識(仮)
        //--------------------------------------------------------------------------------------------//
        bool clicked = InputManager.GetTouchTrigger();
        if (clicked)
        {
            Destroy(this.gameObject);
        }

    }
}