using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndSequenceMenu : MonoBehaviour
{

    private bool Returning = false;
    public float TransitionTimer;
    public AudioSource WhooshSFX;
    public Animator fadeanima;
    bool WhooshPlayed = false;

    void Start()
    {
        WhooshPlayed = false;
    }

    void Update()
    {
        if (Returning)
        {
            TransitionTimer++;
            if (!WhooshPlayed)
            {
                WhooshSFX.Play(0);
                WhooshPlayed = true;
                fadeanima.SetTrigger("FadeOut");
            }
        }
        if (TransitionTimer >= 450)
        {
            SceneManager.LoadScene("SCIFIESCAPE");
        }
    }

    // Start is called before the first frame update

    public void Return()
    {
        Returning = true;
    }
    public void Quit()
    {
        Application.Quit();
    }
}
