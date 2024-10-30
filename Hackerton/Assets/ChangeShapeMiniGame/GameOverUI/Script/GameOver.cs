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
        [SerializeField] private TextMeshProUGUI currentScoreText;
        [SerializeField] private TextMeshProUGUI bestScore;
        [SerializeField] private GameObject scoreChangedPanel;
        private int _bestScore;

        private void Start()
        {
            gameObject.SetActive(false);
        }

        private void OnEnable()
        {
            scoreChangedPanel.SetActive(false); 
        }
        

        public void SetUp(int currentScore)
        {
            _bestScore = PlayerPrefs.GetInt(name);
            // _currentScore = Timer.Score;
            if (_bestScore < currentScore)
            {
                scoreChangedPanel.SetActive(true);
                PlayerPrefs.SetInt(name,currentScore);
            }

            bestScore.text = "최고 점수: " + _bestScore;
            currentScoreText.text = "현재 점수: "+ currentScore;
        }


        public void ToMain()
        {
            SceneManager.LoadScene(0);
        }

        public void ReStart()
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}
