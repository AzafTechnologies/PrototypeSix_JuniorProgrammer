using UnityEngine;
using UnityEngine.InputSystem;

public class playerMovement : MonoBehaviour
{
    private Rigidbody playerRb;

    public InputAction jumpInput;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
        

        jumpInput.Enable();
    }

    // Update is called once per frame
    void Update()
    {
        if (jumpInput.triggered)
        {
            playerRb.AddForce(Vector3.up * 10, ForceMode.Impulse);
        }
    }
}
