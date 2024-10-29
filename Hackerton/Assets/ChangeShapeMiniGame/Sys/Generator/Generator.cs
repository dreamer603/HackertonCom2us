using UnityEngine;

namespace ChangeShapeMiniGame.Sys.Timer
{
    public class Generator : MonoBehaviour
    {
        [Header("생성 목록")] public GameObject[] spawnArr;
        [Header("생성주기")] public float spawnTime;
        [Header("점수문턱")] public int highestOnStage;
        public static int HardNess;
        private float _timer;
        private void Start()
        {
            HardNess = 0;
        }
        
        private void Update()
        {
            _timer += Time.deltaTime;
            HardnessChange();
            HardnessCheck();
            Generate();
            
        }

        private void HardnessChange()
        {
            if (Timer.Score >= highestOnStage*HardNess+1)
            {
                HardNess++;
            }
        }

        private void HardnessCheck()
        {
            switch (HardNess)
            {
                case 0:
                    spawnTime = 3;
                    break;
                case 1:
                    spawnTime = 2.5f;
                    break;
                case 2:
                    spawnTime = 2f;
                    break;
                case 3:
                    spawnTime = 1.5f;
                    break;
                case 4:
                    spawnTime = 1f;
                    break;
                case 5:
                    spawnTime = 0.8f;
                    break;
                default:
                    spawnTime = 0.8f;
                    break;
            }
        }

        private void Generate()
        {
            if (!(_timer > spawnTime)) return;
            RandomSpawn();
            _timer = 0;
        }

        private void RandomSpawn()
        {
            var i=Random.Range(0, 4);
            Instantiate(spawnArr[i], gameObject.transform.position, Quaternion.identity);
        }
    }
}
