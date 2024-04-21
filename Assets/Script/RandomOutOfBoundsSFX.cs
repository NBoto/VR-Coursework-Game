using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomOutOfBoundsSFX : MonoBehaviour
{

    public AudioSource SFXSource;
    public AudioClip[] SFXClips;
    public float PlayTimer;



    // Start is called before the first frame update
    void Start()
    {
        PlayTimer = Random.Range(500, 1200);
    }

    // Update is called once per frame
    void Update()
    {
        if (PlayTimer <= 0)
        {
            AudioClip RandomSFX = SFXClips[Random.Range(0, SFXClips.Length)];
            SFXSource.PlayOneShot(RandomSFX);
            PlayTimer = Random.Range(500, 1200);
        }
        if (PlayTimer > 0)
        {
            PlayTimer = PlayTimer - 1;
        }
    }
}
