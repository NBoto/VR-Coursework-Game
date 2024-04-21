using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ExitScript : MonoBehaviour
{
    private bool Escaping = false;
    public float TransitionTimer;
    public AudioSource WhooshSFX;
    public Animator fadeanima;
    bool WhooshPlayed = false;
    // Start is called before the first frame update
    void Start()
    {
        WhooshPlayed = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Escaping)
        {
            TransitionTimer++;
            if (!WhooshPlayed)
            {
                WhooshSFX.Play(0);
                WhooshPlayed = true;
                fadeanima.SetTrigger("FadeOut");
            }
        }
        if (TransitionTimer >= 250)
        {
            SceneManager.LoadScene("SCIFIESCAPEEND");
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
