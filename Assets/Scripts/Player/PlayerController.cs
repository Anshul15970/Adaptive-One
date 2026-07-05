using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public float moveSpeed = 5f;
    private CharacterController controller;
    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        Debug.Log("Horizontal: " + horizontal + " Vertical: " + vertical);
        Vector3 movement = new Vector3(horizontal , 0f , vertical);
        controller.Move(movement * moveSpeed * Time.deltaTime);
    }
}
