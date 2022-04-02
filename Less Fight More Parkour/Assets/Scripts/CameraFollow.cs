using UnityEngine;

public class CameraFollow : MonoBehaviour {

    public Transform target;

    public float smoothSpeed = .125f;

    public Vector3 offset;

    private void FixedUpdate()
    {
        Vector3 disaredPosition = target.position + offset;
        transform.position = Vector3.Lerp(transform.position, disaredPosition, smoothSpeed);
    }
}
