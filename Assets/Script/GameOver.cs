<<<<<<< HEAD
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOver : MonoBehaviour
{
    
    private void OnCollisionEnter(Collision collision)
    {
        if (GameManager.instance == null)
        {
            GameManager.instance = FindAnyObjectByType<GameManager>();
        }
        if (GameManager.instance != null)
        {

            int blocks = SceneData.totalBlocks;
            GameManager.instance.EndGame(blocks);
            Destroy(collision.gameObject);

        }
        else
        {
            Debug.Log("ゲームマネージャーがインスタンス化されていません");
        }
    }
}
=======
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        SceneManager.LoadScene("Result");
    }
}
>>>>>>> 9b3426895557fec5d65bd4047fa5975dcf2f6a4b
