using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ScoreManager : MonoBehaviour
{
    public Text scoreText;  // UI 텍스트 요소
    private int score = 0;  // 현재 점수

    private void Start()
    {
        StartCoroutine(UpdateScoreCoroutine());
    }

    private IEnumerator UpdateScoreCoroutine()
    {
        while (true)
        {
            yield return new WaitForSeconds(0.3f);  // 0.3초 대기
            if (!FishingManage.instance.isEnd)
            {
                score += 1;  // 점수 1 증가
                scoreText.text = "점수: " + score;  // 점수 UI 업데이트
                FishingManage.instance.score = score;
            }
        }
    }
}
