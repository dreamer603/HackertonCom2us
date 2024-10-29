using TMPro;
using UnityEngine;

namespace ChangeShapeMiniGame.Sys.Timer
{
    public class Timer : MonoBehaviour
    {
        private float _time;
        public static int Score;
        [SerializeField] private TextMeshProUGUI timeUi;
        private void Start()
        {
            _time = 0;
        }
    
        private void Update()
        {
            _time += Time.deltaTime;
            Score = (int)_time / 1;
            timeUi.text = Score.ToString();
        }
    }
}
