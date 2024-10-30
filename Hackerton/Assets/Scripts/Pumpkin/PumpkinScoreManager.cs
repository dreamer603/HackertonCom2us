using System.Collections;
using System.Collections.Generic;
using ChangeShapeMiniGame.GameOverUI.Script;
using TMPro;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class PumpkinScoreManager : MonoBehaviour
{
    public static PumpkinScoreManager Instance = null;

    public TextMeshProUGUI scoreText;

    public GameObject gameOverPanel;

    private int _score;
    
    // Start is called before the first frame update
    void Start()
    {
        Instance = this;
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = _score.ToString();
    }

    public void GameOver()
    {
        Debug.Log("GameOver");
        gameOverPanel.SetActive(true);
        GameOver gameOver = gameOverPanel.GetComponent<GameOver>();
        gameOver.SetUp(_score);
        PumpkinManager.Instance.pumpkinObjectPools.Clear();
    }

    public int Score
    {
        get { return _score; }
        set { _score = value; }
    }
}
