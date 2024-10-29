using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private Sprite[] playerImg;
    private SpriteRenderer _sr;
    private int _tabCount;
    public static ParticleSystem ParticleSystem;
    public static int ShapeType;
    public static bool IsAlive;
    private void Start()
    {
        IsAlive = true;
        ParticleSystem = GameObject.FindWithTag("prt").GetComponent<ParticleSystem>();
        ParticleSystem.Stop();
        _sr = GetComponent<SpriteRenderer>();
        ShapeType = Random.Range(0, 4);
        _tabCount = ShapeType;
        ShapeCheck();
    }

    private void Update()
    {

        if (Input.GetMouseButtonDown(0))
        {
            _tabCount++;
            ShapeType = _tabCount % 4;
            ShapeCheck();
        }
    }
    


    private void ShapeCheck()
    {
        _sr.sprite = playerImg[ShapeType];
    }
}
