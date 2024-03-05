using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NearbyOpenDoor : MonoBehaviour
{
    //[SerializeField] Animator Animator;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        /*
        if ((this.transform.position - FPSPlayer.transform.position).sqrMagnitude < 45.0f)
        {
            Animator.SetBool("character_nearby", true);
            //Debug.Log("In Radius");
        }
        else
        {
            Animator.SetBool("character_nearby", false);
        }*/

    }

    private void OnTriggerEnter(Collider Other)
    {
        if (Other.CompareTag("Player"))
        {
            this.GetComponent<Animator>().SetBool("character_nearby", true);
            //Debug.Log("In Radius");
        }
    }
    private void OnTriggerExit(Collider Other)
    {
        if (Other.CompareTag("Player"))
        {
            this.GetComponent<Animator>().SetBool("character_nearby", false);
        }
    }
}
