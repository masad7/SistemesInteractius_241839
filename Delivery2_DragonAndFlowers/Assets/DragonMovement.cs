using UnityEngine;

public class DragonMovement : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float rotationSpeed = 100f;
    public float verticalSpeed = 3f;

    void Update()
    {
        float move = Input.GetAxis("Vertical");       // W / S
        float rotate = Input.GetAxis("Horizontal");   // A / D

        transform.Translate(Vector3.forward * move * moveSpeed * Time.deltaTime);
        transform.Rotate(Vector3.up * rotate * rotationSpeed * Time.deltaTime);

        if (Input.GetKey(KeyCode.Space))
        {
            transform.Translate(Vector3.up * verticalSpeed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.LeftControl))
        {
            transform.Translate(Vector3.down * verticalSpeed * Time.deltaTime);
        }
    }
}