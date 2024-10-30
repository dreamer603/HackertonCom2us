using UnityEngine;

public class Fishmove : MonoBehaviour
{
    public float baseInitialSpeed = 1.0f; // ù �������� �⺻ �ʱ� �ӵ�
    public float speedIncrement = 0.05f; // �� �������� ������ ������ ������ �ӵ� ��
    public static float nextInitialSpeed; // ���� �������� ���� �ӵ�

    private float speed; // ���� �������� �ӵ�

    private void Awake()
    {
        // ù �������� ��� �⺻ �ӵ��� �ʱ�ȭ
        if (nextInitialSpeed == 0)
        {
            nextInitialSpeed = baseInitialSpeed;
        }

        // ���� �������� ���� �ӵ��� �����ϰ�, ���� �������� ���� �ӵ��� ������Ŵ
        speed = nextInitialSpeed;
        nextInitialSpeed += speedIncrement;
    }

    private void Update()
    {
        // ���� �ӵ��� �̵�
        transform.Translate(Vector2.right * speed * Time.deltaTime);
    }
}