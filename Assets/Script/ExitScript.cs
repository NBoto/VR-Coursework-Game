using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.XR;
using UnityEngine.XR.Interaction.Toolkit;

public class ExitScript : MonoBehaviour
{
    private bool Escaping = false;
    public float TransitionTimer;
    public AudioSource WhooshSFX;
    public Animator FPSfadeanima;
    public Animator VRfadeanima;
    public GameObject FPSCanvas;
    public GameObject VRCanvas;
    bool WhooshPlayed = false;
    // Start is called before the first frame update
    void Start()
    {
        WhooshPlayed = false;
        if (XRSettings.isDeviceActive || XRSettings.loadedDeviceName == "OpenXR Display")
        {
            Debug.Log("Using Device: " + XRSettings.loadedDeviceName);
            FPSCanvas.SetActive(false);
        }
        else
        {
            Debug.Log("Using FPS Rig");
            VRCanvas.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Escaping)
        {
            TransitionTimer++;
            if (!WhooshPlayed)
            {
                WhooshSFX.Play(0);
                WhooshPlayed = true;
                if (XRSettings.isDeviceActive || XRSettings.loadedDeviceName == "OpenXR Display")
                {
                    VRfadeanima.SetTrigger("FadeOut");
                }
                else
                {
                    FPSfadeanima.SetTrigger("FadeOut");
                }
            }
        }
        if (TransitionTimer >= 250)
        {
            SceneManager.LoadScene("SCIFIESCAPEEND");
        }
    }

    private void OnTriggerEnter(Collider Other)
    {
        if (Other.CompareTag("Player"))
        {
            if (!Escaping)
            {
                Debug.Log("Finallly freeeeee!");
                Escaping = true;
            }
        }
    }

}
