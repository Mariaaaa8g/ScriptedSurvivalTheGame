using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float speed = 1f;

    void Update()
    {
        float moveX = Input.GetAxis("Horizontal");
        float moveY = Input.GetAxis("Vertical");

        transform.position += new Vector3(moveX, moveY, 0) * speed * Time.deltaTime;

        if (moveX != 0 || moveY != 0)
        {
            Rotate(new Vector2(moveX, moveY));
        }
    }

    public void Rotate(Vector2 direction)
    {
        var angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        var roundedAngle = Mathf.Round(angle / 45f) * 45f;
        transform.rotation = Quaternion.Euler(0, 0, roundedAngle);
    }
}