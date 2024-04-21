using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using static UnityEngine.CullingGroup;

public class ConsoleScript : MonoBehaviour
{
    [SerializeField] GameObject Forcefield;
    [SerializeField] GameObject ForcefieldLightOn;
    [SerializeField] GameObject ForcefieldGenLightOff;
    [SerializeField] GameObject ForcefieldGenLightOn;
    [SerializeField] AudioSource ActivatedSFX;
    [SerializeField] AudioSource ActivatedSFX2;
    bool ForcefieldInactive;
    bool StateChange;
    // Start is called before the first frame update
    void Start()
    {
        StateChange = false;
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
            if (!StateChange)
            {
                ActivatedSFX.Play(0);
                ActivatedSFX2.Play(0);
                StateChange = true;
            }
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
