using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Restart : MonoBehaviour
{
    public int sceneId;
    public void Restarte()
    {
        SceneManager.LoadSceneAsync(1);
    }

    public void ExitQuit()
    {
        Application.Quit();
    }

}
