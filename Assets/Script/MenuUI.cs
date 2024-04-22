using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.XR.Interaction.Toolkit;

public class MenuUI : MonoBehaviour
{

    [SerializeField] public GameObject XRLocomotion;
    [SerializeField] public GameObject XRTeleportRay;
    [SerializeField] public GameObject XRLineRay;
    private bool StateChanged;
    private float Delay = 10;

    // Start is called before the first frame update
    void Start()
    {
        XRLocomotion.GetComponent<TeleportationProvider>().enabled = false;
        XRLocomotion.GetComponent<ActionBasedSnapTurnProvider>().enabled = false;
        XRLocomotion.GetComponent<ActionBasedContinuousMoveProvider>().enabled = true;
        XRLocomotion.GetComponent<ActionBasedContinuousTurnProvider>().enabled = true;
        XRTeleportRay.SetActive(false);
        XRLineRay.SetActive(true);
    }

    private void Update()
    {
        /*
        if (Delay > 0)
        {
            Delay--;
        }*/
    }

    public void ToggleSnapping()
    {
        /*
        if (!StateChanged & Delay <= 0)
        {
            XRLocomotion.GetComponent<ActionBasedSnapTurnProvider>().enabled = true;
            XRLocomotion.GetComponent<ActionBasedContinuousTurnProvider>().enabled = false;
            Delay = 10;
            StateChanged = true;
        }
        if (StateChanged & Delay <= 0)
        {
            XRLocomotion.GetComponent<ActionBasedSnapTurnProvider>().enabled = false;
            XRLocomotion.GetComponent<ActionBasedContinuousTurnProvider>().enabled = true;
            Delay = 10;
            StateChanged = false;
        }*/
        if (XRLocomotion.GetComponent<ActionBasedSnapTurnProvider>().enabled == false)
        {
            XRLocomotion.GetComponent<ActionBasedSnapTurnProvider>().enabled = true;
            XRLocomotion.GetComponent<ActionBasedContinuousTurnProvider>().enabled = false;
        }
        else
        {
            XRLocomotion.GetComponent<ActionBasedSnapTurnProvider>().enabled = false;
            XRLocomotion.GetComponent<ActionBasedContinuousTurnProvider>().enabled = true;
        }
        //return;
    }

    public void ToggleTeleport()
    {
        /*
        if (!StateChanged & Delay <= 0)
        {
            XRLocomotion.GetComponent<TeleportationProvider>().enabled = true;
            XRLocomotion.GetComponent<ActionBasedContinuousMoveProvider>().enabled = false;
            Delay = 10;
            StateChanged = true;
        }
        if (StateChanged & Delay <= 0)
        {
            XRLocomotion.GetComponent<TeleportationProvider>().enabled = false;
            XRLocomotion.GetComponent<ActionBasedContinuousMoveProvider>().enabled = true;
            Delay = 10;
            StateChanged = false;
        }*/
        if (XRLocomotion.GetComponent<TeleportationProvider>().enabled == false)
        {
            XRTeleportRay.SetActive(true);
            XRLineRay.SetActive(false);
            XRLocomotion.GetComponent<TeleportationProvider>().enabled = true;
            XRLocomotion.GetComponent<ActionBasedContinuousMoveProvider>().enabled = false;
        }
        else
        {
            XRLocomotion.GetComponent<TeleportationProvider>().enabled = false;
            XRTeleportRay.SetActive(false);
            XRLineRay.SetActive(true);
            XRLocomotion.GetComponent<ActionBasedContinuousMoveProvider>().enabled = true;
        }
        //return;

    }

    public void Quit()
    {
        Application.Quit();
    }
}
