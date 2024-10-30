using UnityEngine;

public class Fishdelete : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        // 충돌한 객체의 태그가 Wall인지 확인
        if (other.CompareTag("Wall"))
        {
            // 이 물고기 객체 삭제
            Destroy(gameObject);
        }
    }
}
