using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ConsoleScript : MonoBehaviour
{
    [SerializeField] GameObject Forcefield;
    [SerializeField] GameObject ForcefieldLightOn;
    [SerializeField] GameObject ForcefieldGenLightOff;
    [SerializeField] GameObject ForcefieldGenLightOn;
    bool ForcefieldInactive;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (ForcefieldInactive)
        {
            ForcefieldGenLightOff.SetActive(false);
            ForcefieldGenLightOn.SetActive(true);
            Forcefield.SetActive(false);
            ForcefieldLightOn.SetActive(false);
        }
        else
        {
            ForcefieldGenLightOff.SetActive(true);
            ForcefieldGenLightOn.SetActive(false);
            Forcefield.SetActive(true);
            ForcefieldLightOn.SetActive(true);
        }
    }

    private void OnTriggerEnter(Collider Other)
    {
        if (Other.CompareTag("Player"))
        {
            ForcefieldInactive = true;
            //Debug.Log("In Radius");
        }
    }
}
