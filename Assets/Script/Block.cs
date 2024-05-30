using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block : MonoBehaviour
{
    public int score = 10;
    //何かとぶつかったときビルトインメソッド
    private void OnCollisionEnter(Collision collision)
    {
        ScoreScript.instance.ScrerManager(score);   

        //ゲームオブジェクトを削除
        Destroy(gameObject);
    }
}
