using UnityEngine;

public class CameraController : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public Transform player;
    public Vector3 offset = new Vector3(0, 5, -8);
    
    void LateUpdate()
    {
        transform.position = player.position + offset;
    }
}
