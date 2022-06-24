using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyLever : MonoBehaviour
{
    public Alavanca lever;
    public GameObject toBeDestroyed;

    private void Update()
    {
        if(!lever)
        {
            return;
        }
        if(!toBeDestroyed)
        {
            return;

        }

        if(lever.isOn)
        {
            Destroy(gameObject);
        }
    }
}
