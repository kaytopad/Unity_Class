using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block : MonoBehaviour
{
    public int score = 10;
    //�����ƂԂ������Ƃ��r���g�C�����\�b�h
    private void OnCollisionEnter(Collision collision)
    {
        ScoreScript.instance.ScrerManager(score);   

        //�Q�[���I�u�W�F�N�g���폜
        Destroy(gameObject);
    }
}
