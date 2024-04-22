using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VRFootsteps : MonoBehaviour
{
    [SerializeField] public CharacterController controller;
    public AudioSource FootstepSource;
    public AudioClip[] FootstepClips;
    public float FootstepTimer;

    // Start is called before the first frame update
    void Start()
    {
        controller = this.GetComponent<CharacterController>();
        FootstepTimer = 20;
    }

    // Update is called once per frame
    void Update()
    {
        if (this.gameObject.transform.hasChanged)
        {
            if (FootstepTimer <= 0)
            {
                AudioClip RandomSFX = FootstepClips[Random.Range(0, FootstepClips.Length)];
                FootstepSource.PlayOneShot(RandomSFX);
                FootstepTimer = 20;
            }
            if (FootstepTimer > 0)
            {
                FootstepTimer = FootstepTimer - 1;
            }
            transform.hasChanged = false;
        }
    }
}
