using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorReactToBattery : MonoBehaviour
{
    public AudioSource OpenSFX;
    public AudioSource SuccessSFX;
    public AudioSource CloseSFX;
    public AudioSource NotSuccessSFX;
    public bool StateChange;

    //[SerializeField] Animator Animator;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (this.GetComponent<Animator>().GetBool("character_nearby") == true & StateChange)
        {
            //Debug.Log("Open");
            OpenSFX.Play(0);
            SuccessSFX.Play(0);
            StateChange = false;
        }
        if (this.GetComponent<Animator>().GetBool("character_nearby") == false & !StateChange)
        {
            CloseSFX.Play(0);
            NotSuccessSFX.Play(0);
            //Debug.Log("Closed");
            StateChange = true;
        }

    }

}
