using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour
{
    //クラスの唯一のインスタンスを保持す静的変数
    public static ScoreScript instance;

    //スコアを表示するためのTextコンポーネント
    public GameObject scoreText;
    public int totalScore = 0;

    //Amakeメソッドでインスタンスの初期化を行う
    private void Awake()
    {
        //インスタンスが存在しない場合はこのインスタンスを設定
        if(instance==null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);//シーンをまたいでもインスタンス化を保持できる
        }
        else
        {
            Destroy(gameObject);//既にインスタンスが存在する場合は新しいインスタンス化を破棄
        }
    }

    //スコアを更新し、Textコンポーネントに反映するメソッド
    public void ScoreManager(int score)
    {
        totalScore += score;
        UpdateScoreText();
    }

    //スコアをtextコンポーネントに表示するメソッド
    private void UpdateScoreText()
    {
        this.scoreText.GetComponent<TextMeshProUGUI>().text = "Score" + totalScore.ToString();
    }
   
}
