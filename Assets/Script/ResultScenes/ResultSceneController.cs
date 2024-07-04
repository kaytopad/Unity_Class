using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ResultSceneController : MonoBehaviour
{
    //�e��I�u�W�F�N�g�̐���
    public GameObject scoreTextObject;      //�X�R�A
    public GameObject gameResultObject;     //�Q�[���I�[�o�[���Q�[���N���A

    //�e�L�X�g
    private Text scoreText;
    private Text gameResult;
    // Start is called before the first frame update
    void Start()
    {
        //�e�팋�ʂ��I�u�W�F�N�g�ɓn��
        scoreText = scoreTextObject.GetComponent<Text>();
        gameResult = gameResultObject.GetComponent<Text>();

        scoreText.text = "SCORE :" + SceneData.score;

        //GameOver
        if (SceneData.totalBlocks == 0 )
        {
            gameResult.text = "GAME CLEAR";
            gameResult.color = Color.yellow;
        }
        else
        {
            gameResult.text = "GAME OVER";
            gameResult.color = Color.red;

        }
    }

}
