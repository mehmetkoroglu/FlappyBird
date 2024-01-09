using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField] Transform player;
    [SerializeField] float followSpeed = 10f;

    void Update()
    {
        Vector3 cameraPos = new(player.position.x, 0f, -10f);
        transform.position = Vector3.Lerp(transform.position, cameraPos, followSpeed * Time.deltaTime);
    }
}
