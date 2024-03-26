using System.Collections;
using System.Collections.Generic;
using Unity.Android.Gradle.Manifest;
using UnityEngine;
using UnityEngine.InputSystem;

public class ToggleMenuUI : MonoBehaviour
{
    [SerializeField] private InputActionReference toggleUI;
    private bool IsActive = false;

    private void Start()
    {
        toggleUI.action.performed += ToggleUI;
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
