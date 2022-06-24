using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Portal : MonoBehaviour
{
    public int sceneId;

    public AudioSource clip;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player1") || collision.gameObject.CompareTag("Player2"))
        {
            clip.Play();
            new WaitForSeconds(10f);
            SceneManager.LoadSceneAsync(sceneId);
            Debug.Log("Portal");
        }
    }
}
