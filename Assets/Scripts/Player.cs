using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField]internal bool ActP1, ActP2;

    private bool KeyE;


    private void Start()
    {
        ActP1 = true;
        ActP2 = false;
    }
    private void Update()
    {
        KeyE = Input.GetKeyDown(KeyCode.Q);
        ChangePlayer();
    }
    void ChangePlayer()
    {
        if(KeyE)
        {
            if(!ActP2)
            {
                ActP1 = false;
                ActP2 = true;
                Debug.Log($"P1: {ActP1}, P2: {ActP2}");
            }
            else
            {
                ActP1 = true;
                ActP2 = false;
                Debug.Log($"P1: {ActP1}, P2: {ActP2}");
            }
        }
        
    }
    
}
