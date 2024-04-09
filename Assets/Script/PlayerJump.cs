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
    [SerializeField] LayerMask teleMask;
    [SerializeField] float gravity = -1f;
    [SerializeField] Transform feetPos;
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
        isGrounded = Physics.CheckSphere(feetPos.position - (new Vector3(0, feetPos.position.y, 0)), 0.01f, (groundMask | teleMask));
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