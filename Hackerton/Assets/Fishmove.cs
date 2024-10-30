using UnityEngine;

public class Fishmove : MonoBehaviour
{
    public float baseInitialSpeed = 1.0f; // 첫 프리팹의 기본 초기 속도
    public float speedIncrement = 0.05f; // 각 프리팹이 생성될 때마다 증가할 속도 값
    public static float nextInitialSpeed; // 다음 프리팹의 시작 속도

    private float speed; // 현재 프리팹의 속도

    private void Awake()
    {
        // 첫 프리팹일 경우 기본 속도로 초기화
        if (nextInitialSpeed == 0)
        {
            nextInitialSpeed = baseInitialSpeed;
        }

        // 현재 프리팹의 시작 속도를 설정하고, 다음 프리팹의 시작 속도를 증가시킴
        speed = nextInitialSpeed;
        nextInitialSpeed += speedIncrement;
    }

    private void Update()
    {
        // 현재 속도로 이동
        transform.Translate(Vector2.right * speed * Time.deltaTime);
    }
}