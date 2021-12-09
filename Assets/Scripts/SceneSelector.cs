using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSelector : MonoBehaviour
{
        public void LoadSceneCato()
    {
        SceneManager.LoadScene(1);
    }

    public void LoadScenePlane()
    {
        SceneManager.LoadScene(2);
    }

    public void LoadSceneGusei()
    {
        SceneManager.LoadScene(3);
    }

    public void LoadSceneTux()
    {
        SceneManager.LoadScene(4);
    }
}
