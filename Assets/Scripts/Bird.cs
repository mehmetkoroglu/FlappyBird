using UnityEngine;

public class Bird : MonoBehaviour
{
    [SerializeField] private float jump = 10f;
    [SerializeField] private float jumpSpeed = 10f;
    [SerializeField] private float fallSpeed = 2f;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 jumpTransform = new(transform.position.x, transform.position.y + jump, transform.position.z);
            transform.position = Vector3.Lerp(transform.position, jumpTransform, Time.deltaTime * jumpSpeed);
        }

        transform.position += fallSpeed * Time.deltaTime * (Vector3.down + Vector3.right);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Obstacle"))
        {
            Time.timeScale = 0f;
        }
    }
}
