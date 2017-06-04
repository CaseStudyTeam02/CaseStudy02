using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Title_Cloud : MonoBehaviour
{
    ////    ローカル変数
    ////////////////////////////////////////////////////////////////
    public float    MoveSpeedX;             // 移動速度
    private Vector3 CloudInitPosition;      // 初期位置
    
    ////    初期化処理
    ////////////////////////////////////////////////////////////////
    void Start()
    {
        // 初期位置設定
        CloudInitPosition.x = 100.0f;
        CloudInitPosition.y = 20.0f;
        CloudInitPosition.z = 0.0f;
        
        // 移動速度設定
        //MoveSpeedX = -0.1f;

        // 初期位置反映
        transform.position = new Vector3(CloudInitPosition.x, CloudInitPosition.y, CloudInitPosition.z);
    }

    ////    更新処理
    ////////////////////////////////////////////////////////////////
    void Update ()
    {
        // 移動処理
        Move();

        // 自滅処理
        if (transform.position.x <= -10.0f)
        {
            Destroy(this.gameObject);
        }
    }

    ////    移動関数
    ////////////////////////////////////////////////////////////////
    void Move()
    {
        // 位置変更
        transform.Translate(new Vector3(MoveSpeedX, 0, 0));
    }
}
