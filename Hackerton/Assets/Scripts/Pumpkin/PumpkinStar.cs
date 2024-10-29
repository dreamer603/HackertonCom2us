using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PumpkinStar : MonoBehaviour
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
        if (other.gameObject.CompareTag("Player"))
        {
            PumpkinScoreManager.Instance.Score += 300;
        }
        Destroy(gameObject);
        
    }
}
