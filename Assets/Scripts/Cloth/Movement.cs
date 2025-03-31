using UnityEngine;

public class Movement : MonoBehaviour
{
    public float movespeed = 5;

    private Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(horizontal, 0f, vertical).normalized;

        rb.AddForce(movement * movespeed);
    }
}
