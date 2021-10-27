using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Networking;

public class StartScreen : MonoBehaviour
{
    string ID;
    string Password;

    public void OnLoginButtonClicked()
    {
        ID = GameObject.Find("IDInput").GetComponent<InputField>().text;
        Password = GameObject.Find("PasswordInput").GetComponent<InputField>().text;

        Debug.Log("ID : " + ID + "\nPassword : " + Password);

        SceneManager.LoadScene("TownScene", LoadSceneMode.Additive);
    }
}
