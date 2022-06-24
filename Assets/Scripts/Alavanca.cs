using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Alavanca : MonoBehaviour
{
    internal bool isOn;

    public SingPlayer input;

    private Animator anim;
    private int sInt = 0;
    public AudioSource clip;

    private void Awake()
    {
        anim = GetComponent<Animator>();
    }
    private void Update()
    {
        
        if(input.qKey && input.isOnRadius)
        {
            Debug.Log("Ativa alacanva");

            if(!isOn)
            {
                sInt = 1;
                clip.pitch = 0.5f;
                clip.Play();
                anim.Play("LeverRight");
                isOn = true;
            } else
            {
                sInt = 0;
                clip.pitch = 0.6f;
                clip.Play();
                anim.Play("LeverLeft");
                isOn = false;
            }
        }
    }
}
