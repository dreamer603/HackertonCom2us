using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FishingUI : MonoBehaviour
{
    public Image hpFill;

    public FishingCharacter fishingCharacter;

    public bool isEnd;

    private void Start()
    {
        StartCoroutine(Minus());
    }

    void FixedUpdate()
    {
        hpFill.fillAmount = Mathf.Lerp(fishingCharacter.HP / 10f, hpFill.fillAmount, 0.0002f * Time.deltaTime);

    }

    IEnumerator Minus()
    {
        while (true)
        {
            yield return new WaitForSeconds(1f);
            fishingCharacter.HP -= 0.5f;

            if (fishingCharacter.HP <= 0)
                break;
        }

        FishingManage.instance.isEnd = true;
    }
}
