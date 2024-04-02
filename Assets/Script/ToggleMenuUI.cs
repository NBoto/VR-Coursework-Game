using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class ToggleMenuUI : MonoBehaviour
{
    [SerializeField] private InputActionReference toggleUI;
    private bool IsActive = false;

    private void Start()
    {
        toggleUI.action.performed += ToggleUI;
        this.gameObject.SetActive(false);
        IsActive = false;
        //Jump();
    }
    private void ToggleUI(InputAction.CallbackContext context)
    {
        Debug.Log("ToggledMenu");
        if (!IsActive)
        {
            this.gameObject.SetActive(true);
            IsActive = true;
        }
        else
        {
            this.gameObject.SetActive(false);
            IsActive = false;
        }
    }
}
