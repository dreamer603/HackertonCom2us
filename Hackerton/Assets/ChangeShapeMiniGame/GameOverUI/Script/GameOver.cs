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

        [SerializeField] private TextMeshProUGUI nowScore;
        
        [SerializeField] private TextMeshProUGUI bestScore;
        [SerializeField] private GameObject changedPannel;
        private int _nowScore;
        private int _bestScore;
        



        private void OnEnable()
        {
            
            changedPannel.SetActive(false);
                SetUp();
        }
        

        private void SetUp()
        {
            Debug.Log(Timer.Score);
            _bestScore = PlayerPrefs.GetInt(name);
            _nowScore = Timer.Score;
            if (_bestScore < _nowScore)
            {
                changedPannel.SetActive(true);
                PlayerPrefs.SetInt(name,_nowScore);
            }

            bestScore.text = _bestScore.ToString();
            nowScore.text = _nowScore.ToString();
        }
    }
}
