using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block : MonoBehaviour
{
    public int score = 10;
    private BlockGenerator generator;

    private void Start()
    {
        generator = FindObjectOfType<BlockGenerator>();
    }
    //�����ƂԂ������Ƃ��r���g�C�����\�b�h
    private void OnCollisionEnter(Collision collision)
    {
        // スコアをScoreScriptに追加
        if (ScoreScript.instance != null)
        {
            ScoreScript.instance.ScoreManager(score);
        }
        else
        {
            Debug.LogError("ScoreScript instance is not set.");
        }
<<<<<<< HEAD
        //トータルブロックの削除メソッド
        generator.BlocklDestroyed();
=======
>>>>>>> a2691bbb123b82f7daef184b29f349e0c3e16111
        // ゲームオブジェクトを削除
        Destroy(gameObject);
    }
}
