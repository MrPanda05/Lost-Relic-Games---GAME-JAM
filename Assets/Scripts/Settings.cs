using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Settings : MonoBehaviour
{
    public GameObject main;
    public GameObject sett;

    public void ChangedIn()
    {
        main.SetActive(false);
        sett.SetActive(true);
    }

    public void ChangeBck()
    {
        sett.SetActive(false);
        main.SetActive(true);
    }
}
