using UnityEngine;

public class Fishdelete : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        // �浹�� ��ü�� �±װ� Wall���� Ȯ��
        if (other.CompareTag("Wall"))
        {
            // �� ����� ��ü ����
            Destroy(gameObject);
        }
    }
}
