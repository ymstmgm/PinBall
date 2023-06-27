using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    private int score = 0; // 現在の得点
    private Text ScoreText; // 得点を表示するテキストコンポーネント

    // Start is called before the first frame update
    void Start()
    {
        // 初期得点を表示する
        ScoreText = GameObject.FindWithTag("ScoreText").GetComponent<Text>();
        UpdateScoreText();
    }

    // Update is called once per frame
    void OnCollisionEnter(Collision collision)
    {
        // 衝突したオブジェクトがターゲットであるかを判定
        if (collision.gameObject.CompareTag("SmallStarTag"))
        {
            // 小さい星に衝突した場合、10点加算
            score += 10;
        }
        else if (collision.gameObject.CompareTag("LargeStarTag"))
        {
            // 大きい星に衝突した場合、20点加算
            score += 20;
        }
        else if (collision.gameObject.CompareTag("SmallCloudTag"))
        {
            // 小さい雲に衝突した場合、5点加算
            score += 5;
        }

        // 得点を更新して表示する
        UpdateScoreText();
    }

    void UpdateScoreText()
    {
        // 得点をテキストコンポーネントに反映する
        ScoreText.text = "Score: " + score.ToString();
    }
}