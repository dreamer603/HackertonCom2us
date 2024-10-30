using UnityEngine;

public class FishingFloat : MonoBehaviour
{
    public bool isMoving; //찌가 움직이는 중인지
    public bool isDowning; //움직인다면 내려가는 중인지

    public int speed; //찌가 움직이는 속도

    private Rigidbody2D rigid; //찌의 rigidbody

    private void Awake()
    {
        rigid = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        if (isMoving)
        {
            if (isDowning)
                rigid.velocity = Vector3.down * Time.deltaTime * speed;
            else
                rigid.velocity = Vector3.up * Time.deltaTime * speed;
        }
        else
            rigid.velocity = Vector3.zero;
    }

    float addingHPAmount;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("defPos"))
        {
            isMoving = false;
            isDowning = true;

            if (addingHPAmount != 0)
            {
                GetComponentInParent<FishingCharacter>().HP += addingHPAmount;
                transform.GetChild(0).GetComponent<SpriteRenderer>().sprite = null;

                addingHPAmount = 0;
            }
        }
        else
        {
            isDowning = false;

            if (collision.CompareTag("Fish") && addingHPAmount == 0)
            {
                addingHPAmount += collision.GetComponent<FishingTestFish>().hpAmount;

                transform.GetChild(0).GetComponent<SpriteRenderer>().sprite
                    = collision.GetComponent<SpriteRenderer>().sprite;
                Destroy(collision.gameObject);
            }
        }
    }
}
