using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class ToggleMenuUI : MonoBehaviour
{
    [SerializeField] private InputActionReference toggleUI;
    [SerializeField] public GameObject LeftRay;
    private bool IsActive = false;
    private Vector3 InitScale;

    private void Start()
    {
        InitScale = transform.localScale;
        toggleUI.action.performed += ToggleUI;
        //this.gameObject.SetActive(false);
        IsActive = false;
        transform.localScale = new Vector3(0, 0, 0);
        //Jump();
    }

    IEnumerator ScaleTo(Vector3 newScale)
    {
        float progress = 0;

        while(progress <= 1)
        {
            transform.localScale = Vector3.Lerp(this.transform.localScale, newScale, progress);
            progress += Time.deltaTime * Time.timeScale;
            yield return null;
        }
        transform.localScale = newScale;
    }
    private void ToggleUI(InputAction.CallbackContext context)
    {
        Debug.Log("ToggledMenu");
        if (!IsActive)
        {
            StartCoroutine(ScaleTo(InitScale));
            //this.gameObject.SetActive(true);
            //LeftRay.gameObject.SetActive(false);
            IsActive = true;
        }
        else
        {
            StartCoroutine(ScaleTo(new Vector3(0,0,0)));
            //this.gameObject.SetActive(false);
            //LeftRay.gameObject.SetActive(true);
            IsActive = false;
        }
    }
}
