using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PumpkinManager : MonoBehaviour
{
    public static PumpkinManager Instance = null;
    
    public List<GameObject> pumpkinObjectPools;

    public Transform[] _spawnPoints;

    public GameObject pumpkinObject;

    public GameObject starObject;
    
    private int _poolSize = 10;

    [SerializeField]
    private float _createTime = 2f;

    private float _currentTime;
    
    // Start is called before the first frame update
    void Start()
    {
        Instance = this;
        
        for (int i = 0; i < _poolSize; i++)
        {
            GameObject pumpkin = Instantiate(pumpkinObject);
            pumpkinObjectPools.Add(pumpkin);
            pumpkin.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        _currentTime += Time.deltaTime;

        if (_currentTime > _createTime)
        {
            int dropStar = Random.Range(0, 20);

            if (dropStar == 1)
            {
                GameObject star = Instantiate(starObject);
                int index = Random.Range(0, _spawnPoints.Length);
                star.transform.position = _spawnPoints[index].position;
                star.SetActive(true);
            }
            else if (pumpkinObjectPools.Count > 0)
            {
                GameObject pumpkin = pumpkinObjectPools[0];
                pumpkinObjectPools.Remove(pumpkin);
                int index = Random.Range(0, _spawnPoints.Length);
                pumpkin.transform.position = _spawnPoints[index].position;
                pumpkin.SetActive(true);
            }

            _currentTime = 0;
        }
    }

    public float CreateTime
    {
        get { return _createTime; }
        set { _createTime = value; }
    }
}

