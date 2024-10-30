using ChangeShapeMiniGame.GameOverUI.Script;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FishingManage : MonoBehaviour
{
    public static FishingManage instance;

    private void Awake()
    {
        instance = this;

        Fishmove.nextInitialSpeed = 0;
        Fishmove2.nextInitialSpeed = 0;
    }

    public GameObject gameoverPanel;
    public int score;
    public bool isEnd;

    private void Update()
    {
        if (isEnd)
        {
            gameoverPanel.GetComponent<GameOver>().SetUp(score);
            gameoverPanel.SetActive(true);

        }
    }
}
