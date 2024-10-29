using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager Instance = null;

    public TextMeshProUGUI scoreText;

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

    public int Score
    {
        get { return _score; }
        set { _score = value; }
    }
}
