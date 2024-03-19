using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerJump : MonoBehaviour
{
    [SerializeField] private InputActionReference jump;
    [SerializeField] public GameObject Wall;
    [SerializeField] private float jumpHeight = 85;
    [SerializeField] LayerMask groundMask;
    [SerializeField] float gravity = -1f;
    [SerializeField] public CharacterController CC;
    Vector3 movement = Vector3.zero;
    public bool isGrounded;

    private void Start()
    {
        jump.action.performed += Jump;
        //Jump();
    }

    private void Update()
    {
        isGrounded = Physics.CheckSphere(transform.position - (new Vector3(0, transform.localScale.y, 0)), 0.1f, groundMask);
        if (isGrounded)
        {
            movement.y = 0;
        }
        else
        {
            movement.y += gravity * Time.deltaTime;
        }

        CC.Move(movement * Time.deltaTime);
    }

    private void Jump(InputAction.CallbackContext context)
    {
        Debug.Log("Jump?");
        movement.y = Mathf.Sqrt(-2f * gravity * jumpHeight);
        //Wall.SetActive(false);
    }

}
