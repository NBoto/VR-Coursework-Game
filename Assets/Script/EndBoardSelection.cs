using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;
using UnityEngine.SceneManagement;

public class EndBoardSelection : MonoBehaviour
{
    [SerializeField] GameObject VRBoard;
    [SerializeField] GameObject FPSBoard;

    // Start is called before the first frame update
    void Start()
    {
        if (XRSettings.isDeviceActive || XRSettings.loadedDeviceName == "OpenXR Display")
        {
            Debug.Log("Using Device: " + XRSettings.loadedDeviceName);
            FPSBoard.SetActive(false);
        }
        else
        {
            Debug.Log("Using FPS Rig");
            VRBoard.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
