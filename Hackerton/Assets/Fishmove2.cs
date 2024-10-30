using UnityEngine;

public class Fishmove2 : MonoBehaviour
{
    public float speed = 1.0f; // 초기 물고기 이동 속도
    public float acceleration = 0.1f; // 초당 증가할 속도

    private void Update()
    {
        // 초당 속도 증가
        speed += acceleration * Time.deltaTime* -1f;

        // 증가된 속도로 X 축 방향으로 이동
        transform.Translate(Vector2.right * speed * Time.deltaTime);

        // 속도 확인용 출력
        Debug.Log("Current Speed: " + speed);
    }
}
