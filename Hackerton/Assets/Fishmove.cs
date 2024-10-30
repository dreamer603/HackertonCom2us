using UnityEngine;

public class FishMovement : MonoBehaviour
{
    public float speed = 1.0f; // �ʱ� ����� �̵� �ӵ�
    public float acceleration = 0.1f; // �ʴ� ������ �ӵ�

    private void Update()
    {
        // �ʴ� �ӵ� ����
        speed += acceleration * Time.deltaTime;

        // ������ �ӵ��� X �� �������� �̵�
        transform.Translate(Vector2.right * speed * Time.deltaTime);

        // �ӵ� Ȯ�ο� ���
        Debug.Log("Current Speed: " + speed);
    }
}
