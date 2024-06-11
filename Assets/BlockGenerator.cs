using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockGenerator : MonoBehaviour
{
    //GameObject
    public GameObject blockPrefab;      //ブロックのプレファブ
    //ブロックの座標・大きさ
    float span = 0.3f;      //ブロックの間隔
    int row = 4;            //ブロックの列
    int col = 7;            //ブロックの行
    int blockScaleX = 2;    //ブロックの幅
    int blockScaleY = 1;    //ブロックの高さ
    // Start is called before the first frame update
    void Start()
    {
        //ブロックの座標
        int px = -7, py = 5;
        int scoreDefult = 0;
        //ブロックの表示
        for (int i = 0; i < row; i++)
        {
            for (int j = 0; j < col; j++)
            {
                //ゲームオブジェクトとして生成
                GameObject go= Instantiate(blockPrefab);
                go.transform.position = new Vector3(px + (j * (span + blockScaleX)),
                                                    py + (i * (span + blockScaleY)), 0);
            }
        }

        //スコアの初期表示
        if(ScoreScript.instance != null)
        {
            ScoreScript.instance.ScoreManager(scoreDefult);
        }
        else
        {
            Debug.LogError("ScoreScriptのインスタンスがありません。");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
