using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ScoreManager : MonoBehaviour
{
    public Text scoreText;  // UI �ؽ�Ʈ ���
    private int score = 0;  // ���� ����

    private void Start()
    {
        StartCoroutine(UpdateScoreCoroutine());
    }

    private IEnumerator UpdateScoreCoroutine()
    {
        while (true)
        {
            yield return new WaitForSeconds(0.3f);  // 0.3�� ���
            if (!FishingManage.instance.isEnd)
            {
                score += 1;  // ���� 1 ����
                scoreText.text = "����: " + score;  // ���� UI ������Ʈ
                FishingManage.instance.score = score;
            }
        }
    }
}
