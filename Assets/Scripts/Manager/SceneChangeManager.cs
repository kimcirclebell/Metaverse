using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChangeManager : MonoBehaviour
{
    public enum Scenes
    {
        UnknownScene,
        StartScene,
        TownScene,
        BankScene,
        HomeScene,
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    public void SceneChange(Scenes scene)
    {
        SceneManager.LoadScene(scene.ToString(), LoadSceneMode.Single);
    }
}
