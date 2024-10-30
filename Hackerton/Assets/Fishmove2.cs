using UnityEngine;

public class Fishmove2 : MonoBehaviour
{
    public float baseInitialSpeed = 1.0f; 
    public float speedIncrement = 0.05f;
    public static float nextInitialSpeed;

    private float speed; 

    private void Awake()
    {
        if (nextInitialSpeed == 0)
        {
            nextInitialSpeed = baseInitialSpeed;
        }

        speed = nextInitialSpeed;
        nextInitialSpeed += speedIncrement;
    }

    private void Update()
    {
        // 현재 속도로 이동
        transform.Translate(Vector2.left * speed * Time.deltaTime);
    }
}
