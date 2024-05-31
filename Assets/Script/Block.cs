using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block : MonoBehaviour
{
    public int score = 10;
    //�����ƂԂ������Ƃ��r���g�C�����\�b�h
    private void OnCollisionEnter(Collision collision)
    {
        // スコアをScoreScriptに追加
        ScoreScript.instance.ScoreManager(score);

        // ゲームオブジェクトを削除
        Destroy(gameObject);
    }
}
