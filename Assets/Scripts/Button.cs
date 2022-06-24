using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour
{
    internal bool isOn;
    private SpriteRenderer sprite;
    public float yPosMax, yPosMin;
    private int sInt = 0;

    public AudioSource clip;
    // Start is called before the first frame update
    void Awake()
    {
        sprite = GetComponent<SpriteRenderer>();
    }

    // Make button better
//button needs rework, its almost done
    void Update()
    {
        
        if(isOn)
        {
            if(sInt == 0)
            {
                sInt = 1;
                clip.pitch = 1f;
                clip.Play();
            }
            sprite.enabled = false;
        } else
        {
            if(sInt == 1)
            {
                sInt = 0;
                clip.pitch = 0.9f;
                clip.Play();
            }
            sprite.enabled = true;
            
        }


        
        
    }
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        
        if (collision.gameObject.CompareTag("Bloco") | collision.gameObject.CompareTag("Player1") | collision.gameObject.CompareTag("Player2"))
        {
            Debug.Log("Bloco");
            isOn = true;
        }
        
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (!collision.gameObject.CompareTag("Bloco") | (!collision.gameObject.CompareTag("Player1") && !collision.gameObject.CompareTag("Player2")))
        {
            Debug.Log("Bloco");
            isOn = false;
        }
    }
}
