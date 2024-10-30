using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PumpkinPlayer : MonoBehaviour
{
    [SerializeField]
    private float _speed = 2f;

    private Coroutine _workingCoroutine;

    private float _orginScaleX;

    private Animator _animator;

    private Vector3 dir;
    
    // Start is called before the first frame update
    void Start()
    {
        _orginScaleX = transform.localScale.x;
        _animator = GetComponent<Animator>();
        dir = Vector3.right;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
           FlipObject();
           dir *= -1;
        }

        transform.position += dir * _speed * Time.deltaTime;

    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Wall"))
        {
            Debug.Log("Trigger");
            dir *= -1;
            FlipObject();
        }
    }

    private void FlipObject()
    {
        transform.localScale =
            new Vector3(transform.localScale.x * -1, transform.localScale.y, transform.localScale.z);
    }
}
