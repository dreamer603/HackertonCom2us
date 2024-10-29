using Unity.VisualScripting;
using UnityEngine;

namespace ChangeShapeMiniGame.Obstacle.Script
{
    public class Obstacle : MonoBehaviour
    {
        public int idNumber;
        private Rigidbody2D _rb;
        public float moveSpeed;
        private void Start()
        {
            _rb = GetComponent<Rigidbody2D>();
        }
        
        private void Update()
        {
            _rb.velocity = new Vector2(moveSpeed*-1, 0);
        }

        private void OnTriggerEnter2D(Collider2D other)
        {
            if (other.CompareTag("Player") && Player.ShapeType != idNumber)
            {
                Debug.Log("게임오버");
            }
        }
    }
}
