using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BatteryForDoorInput : MonoBehaviour
{
    [SerializeField] GameObject BatteryOperatedDoor;
    bool BatteryOperated;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (BatteryOperated)
        {
            BatteryOperatedDoor.GetComponent<Animator>().SetBool("character_nearby", true);
        }
        else
        {
            BatteryOperatedDoor.GetComponent<Animator>().SetBool("character_nearby", false);
        }
    }

    private void OnTriggerEnter(Collider Other)
    {
        if (Other.CompareTag("Battery"))
        {
            BatteryOperated = true;
            //Debug.Log("In Radius");
        }
    }
    private void OnTriggerExit(Collider Other)
    {
        if (Other.CompareTag("Battery"))
        {
            BatteryOperated = false;
            //Debug.Log("In Radius");
        }
    }
}
