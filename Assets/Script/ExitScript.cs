using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using static System.TimeZoneInfo;

public class ExitScript : MonoBehaviour
{
    private bool Escaping = false;
    public float TransitionTimer;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Escaping)
        {
            TransitionTimer++;
        }
        if (TransitionTimer >= 250)
        {
            //
        }
    }

    private void OnTriggerEnter(Collider Other)
    {
        if (Other.CompareTag("Player"))
        {
            if (!Escaping)
            {
                Debug.Log("Finallly freeeeee!");
                Escaping = true;
            }
        }
    }

}
