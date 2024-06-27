using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockGenerator : MonoBehaviour
{
    //GameObject�̒ǉ�
    public GameObject blockPrefab;
    //�X�p��
    float span = 0.3f;
    int row = 4;
    int col = 7;
    int BlockScaleX = 2;
    int BlockScaleY = 1;
    // Start is called before the first frame update
    void Start()
    {
        //�u���b�N�̃|�W�V����
        int px,py;
        px = -7; py = 5;
        int scoreDefult = 0;
        //�u���b�N�̔z�u
        for (int i = 0; i < row; i++)
        {
            
            for(int j = 0; j < col; j++)
            {
                //�Q�[���I�u�W�F�N�g�̐���
                GameObject go = Instantiate(blockPrefab);
                go.transform.position = new Vector3(px+(j * (span + BlockScaleX)), py + (i * (span + BlockScaleY)), 0);
            }

        }

        ScoreScript.instance.ScoreManager(scoreDefult);
    }

}
