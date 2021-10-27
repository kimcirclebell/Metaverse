using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;

public class WebCall : MonoBehaviour
{
    public Text moneyText;
    string money;

    readonly string getURL = "";
    readonly string postURL = "";
    void Start()
    {
        moneyText.text = "Dwonloading Money Data...";
    }
    
    public void GetMoney()
    {
        StartCoroutine(GetRequest());
    }

    IEnumerator GetRequest()
    {
        UnityWebRequest www = UnityWebRequest.Get(getURL);

        yield return www.SendWebRequest();

        if(www.isNetworkError || www.isHttpError)
        {
            Debug.LogError(www.error);
        }

        else
        {
            moneyText.text = www.downloadHandler.text;
        }
    }

    public void SendMoneyData()
    {
        moneyText.text = "Sending Data...";
        StartCoroutine(PostRequest(money));
    }

    IEnumerator PostRequest(string currMoney)
    {
        List<IMultipartFormSection> wwwForm = new List<IMultipartFormSection>();
        wwwForm.Add(new MultipartFormDataSection("curMoneyKey", currMoney));

        UnityWebRequest www = UnityWebRequest.Post(postURL, wwwForm);

        yield return www.SendWebRequest();

        if(www.isHttpError || www.isNetworkError)
        {
            Debug.LogError(www.error);
        }

        else
        {
            moneyText.text = www.downloadHandler.text;
        }
    }
}
