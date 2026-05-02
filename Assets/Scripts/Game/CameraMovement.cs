using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    [SerializeField] Transform target;
    [SerializeField] float speed;
    Vector3 offset;

    void Start()
    {
        offset = transform.position - target.position;
    }

    void LateUpdate()
    {
        Vector3 cameraPos = new Vector3(target.position.x + offset.x,
                                        offset.y,
                                        target.position.z + offset.z);
        transform.position = Vector3.Lerp(transform.position, cameraPos, Time.time*speed);
    }
}
