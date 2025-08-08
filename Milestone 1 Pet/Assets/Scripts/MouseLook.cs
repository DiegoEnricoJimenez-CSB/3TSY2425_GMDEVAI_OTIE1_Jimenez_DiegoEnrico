using UnityEngine;
public class MouseLook : MonoBehaviour
{
    Vector2 rotation = Vector2.zero;
    public float speed = 3;

    private void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }
    void Update()
    {
        rotation.y += Input.GetAxis("Mouse X");
        //rotation.x += -Input.GetAxis("Mouse Y");

        transform.eulerAngles = (Vector2)rotation * speed;
    }
}