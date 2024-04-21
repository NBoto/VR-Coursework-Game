using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.InputSystem;

public class ToggleMenuUI : MonoBehaviour
{
    [SerializeField] private InputActionReference toggleUI;
    [SerializeField] public GameObject LeftRay;
    //[SerializeField] public GameObject UIMenu;
    private bool IsActive = false;
    private float Delay = 250;
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

    private void Update()
    {
        if (Delay > 0)
        {
            Delay--;
        }
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
        if (!IsActive & Delay <= 0)
        {
            StartCoroutine(ScaleTo(InitScale));
            //this.gameObject.SetActive(true);
            //LeftRay.gameObject.SetActive(false);
            //UIMenu.SetActive(true);
            Delay = 250;
            IsActive = true;
        }
        if (IsActive & Delay <= 0)
        {
            StartCoroutine(ScaleTo(new Vector3(0,0,0)));
            //this.gameObject.SetActive(false);
            //LeftRay.gameObject.SetActive(true);
            //UIMenu.SetActive(false);
            Delay = 250;
            IsActive = false;
        }
    }
}
