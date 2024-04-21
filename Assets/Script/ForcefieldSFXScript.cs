using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForcefieldSFXScript : MonoBehaviour
{
    public AudioSource ForcefieldHumSFX;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (this.isActiveAndEnabled & !ForcefieldHumSFX.isPlaying)
        {
            ForcefieldHumSFX.Play(0);
        }
        if (!this.isActiveAndEnabled & ForcefieldHumSFX.isPlaying)
        {
            ForcefieldHumSFX.Stop();
        }
    }
}
