using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pumpkin : MonoBehaviour
{
    [SerializeField]
    private float _speed = 5f;

    public GameObject hitPumpkinEffect;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.down * _speed * Time.deltaTime;
    }
    
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Instantiate(hitPumpkinEffect);
            hitPumpkinEffect.transform.position = transform.position;
            Destroy(other.gameObject);
            PumpkinManager.Instance.pumpkinObjectPools.Clear();
            PumpkinScoreManager.Instance.GameOver();
            Destroy(gameObject);
        }
        else
        {
            gameObject.SetActive(false);
            PumpkinManager.Instance.pumpkinObjectPools.Add(gameObject);
            PumpkinScoreManager.Instance.Score += 100;
            if (PumpkinScoreManager.Instance.Score % 1000 == 0)
            {
                PumpkinManager.Instance.CreateTime /= 1.5f;
            }
        }
        
    }
}
