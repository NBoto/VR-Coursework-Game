using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForcefieldInactiveSFX : MonoBehaviour
{
    public AudioSource ForcefieldDropSFX;
    [SerializeField] GameObject Forcefield;
    bool StateChange;
    // Start is called before the first frame update
    void Start()
    {
        StateChange = false;
    }

    // Update is called once per frame
    void Update()
    {
        if ( !Forcefield.activeInHierarchy & !ForcefieldDropSFX.isPlaying & !StateChange)
        {
            ForcefieldDropSFX.Play(0);
            StateChange = true;
        }
    }
}
