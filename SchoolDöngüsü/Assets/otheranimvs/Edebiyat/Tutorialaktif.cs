using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tutorialaktif : MonoBehaviour
{
    public GameObject Edebiyatsınav;
    public GameObject Tutorial;

    public void TutorialPlay()
    {
        Edebiyatsınav.SetActive(true);
        Tutorial.SetActive(false);
    }
}
