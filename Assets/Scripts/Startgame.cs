using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Startgame : MonoBehaviour
{
    public int sceneId;
    public void IrtoGo()
    {
        SceneManager.LoadSceneAsync(1);
    }
}
