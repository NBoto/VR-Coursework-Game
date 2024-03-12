using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerJump : MonoBehaviour
{
    [SerializeField] private InputAction jumpButton;
    [SerializeField] private float jumpHeight = 3f;
    [SerializeField] private CharacterController cc;
    [SerializeField] private LayerMask groundLayers;

    private float gravity = Physics.gravity.y;
    private Vector3 movement;

    private void Start()
    {
        //Jump();
    }

    private void Update()
    {
        bool _isGrounded = IsGrounded();

        if (jumpButton.WasPressedThisFrame())
        {
            Debug.Log("Ahahahha");
            Jump();
        }
    }

    public void Jump()
    {
        Debug.Log("Jump?");
        movement.y = Mathf.Sqrt(jumpHeight * -3.0f * gravity);
    }

    [SerializeField] private bool IsGrounded()
    {
        return Physics.CheckSphere(transform.position, 0.2f, groundLayers);
    }

}
