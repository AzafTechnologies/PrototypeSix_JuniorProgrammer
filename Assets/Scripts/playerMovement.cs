using UnityEngine;
using UnityEngine.InputSystem;

public class playerMovement : MonoBehaviour
{
    private Rigidbody playerRb;
    public InputAction jumpInput;
    public float jumpForce = 15.0f;
    public float gravityModifier = 2.0f;
    public bool isGrounded = true;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();

        Physics.gravity *= gravityModifier;

        jumpInput.Enable();
    }

    // Update is called once per frame
    void Update()
    {
        if (jumpInput.triggered && isGrounded)
        {
            playerRb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            isGrounded = false;
        }

        
    }

    private void OnCollisionEnter(Collision collision)
    {
        isGrounded = true;
    }
}
