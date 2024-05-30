using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block : MonoBehaviour
{
    //何かとぶつかったときビルトインメソッド
    private void OnCollisionEnter(Collision collision)
    {
        //ゲームオブジェクトを削除
        Destroy(gameObject);
    }
}
