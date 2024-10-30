using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FishingCharacter : MonoBehaviour
{
    FishingFloat fishingFloat;

    private float maxHP = 10;

    [SerializeField]
    private float hp;
    public  float HP
    {
        get => hp;
        set
        {
            hp = Mathf.Clamp(value, 0, maxHP);
        }
    }

    private void Awake()
    {
        fishingFloat = GetComponentInChildren<FishingFloat>();
        HP = maxHP;
    }

    void OnFish()
    {
        if (!fishingFloat.isMoving)
        {
            fishingFloat.isMoving = true;
            fishingFloat.isDowning = true;
        }
    }
}
