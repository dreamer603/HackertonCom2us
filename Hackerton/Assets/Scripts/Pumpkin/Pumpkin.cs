using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pumpkin : MonoBehaviour
{
    [SerializeField]
    private float _speed = 5f;
    
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
        Destroy(gameObject);
        if (other.gameObject.CompareTag("Player"))
        {
            Destroy(other.gameObject);
        }
        else
        {
            PumpkinManager.Instance.pumpkinObjectPools.Add(other.gameObject);
            ScoreManager.Instance.Score += 100;
            if (ScoreManager.Instance.Score % 1000 == 0)
            {
                PumpkinManager.Instance.CreateTime /= 1.5f;
            }
        }
    }
}
