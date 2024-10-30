using UnityEngine;

namespace ChangeShapeMiniGame.Sys.BackGround
{
    public class BackGroundMove : MonoBehaviour
    {
        private Rigidbody2D _rb2D;
        
        [SerializeField] private GameObject returnPlace;
        [SerializeField] private GameObject target;
        private void Start()
        {
            _rb2D = GetComponent<Rigidbody2D>();
        }
    
        private void Update()
        {
            _rb2D.velocity = new Vector2(-0.8f, 0);
            if (_rb2D.position.x < target.transform.position.x)
            {
                _rb2D.position = returnPlace.transform.position;
            }
        }
    }
}
