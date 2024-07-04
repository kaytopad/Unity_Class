using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ResultSceneController : MonoBehaviour
{
    //各種オブジェクトの生成
    public GameObject scoreTextObject;      //スコア
    public GameObject gameResultObject;     //ゲームオーバーかゲームクリア

    //テキスト
    private Text scoreText;
    private Text gameResult;
    // Start is called before the first frame update
    void Start()
    {
        //各種結果をオブジェクトに渡す
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
