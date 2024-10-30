using System;
using ChangeShapeMiniGame.Sys.Timer;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace ChangeShapeMiniGame.GameOverUI.Script
{
    public class GameOver : MonoBehaviour
    {
        [Header("게임 이름 입력")]
        [SerializeField] private string name;
        [SerializeField] private TextMeshProUGUI currentScore;
        [SerializeField] private TextMeshProUGUI bestScore;
        [SerializeField] private GameObject scoreChangedPanel;
        private int _currentScore;
        private int _bestScore;
        



        private void OnEnable()
        {
            
            scoreChangedPanel.SetActive(false); 
            SetUp();
        }
        

        private void SetUp()
        {
            Debug.Log(Timer.Score);
            _bestScore = PlayerPrefs.GetInt(name);
            _currentScore = Timer.Score;
            if (_bestScore < _currentScore)
            {
                scoreChangedPanel.SetActive(true);
                PlayerPrefs.SetInt(name,_currentScore);
            }

            bestScore.text = "최고 점수: " + _bestScore;
            currentScore.text = "현재 점수: "+_currentScore;
        }
    }
}
