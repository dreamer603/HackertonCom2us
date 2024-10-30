using System;
using ChangeShapeMiniGame.GameOverUI.Script;
using TMPro;
using UnityEngine;

namespace ChangeShapeMiniGame.Sys.Timer
{
    public class Timer : MonoBehaviour
    {
        private float _time;
        public static int Score;
        [SerializeField] private TextMeshProUGUI timeUi;
        [SerializeField]private GameOver _gameOver;
        [SerializeField]private GameObject _gameOverPanel;

        private void Start()
        {
            Score = 0;
            _time = 0;
        }
    
        private void Update()
        {
            if (Player.IsAlive)
            {
                _time += Time.deltaTime;
                Score = (int)_time / 1;
                timeUi.text = Score.ToString();
            }
            else
            {
                if (_gameOverPanel.activeSelf) return;
                _gameOverPanel.SetActive(true);
                _gameOver.SetUp(Score);
                Destroy(gameObject);

            }
        }
    }
}
