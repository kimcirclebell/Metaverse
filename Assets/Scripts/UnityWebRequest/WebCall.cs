using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;

public class WebCall : MonoBehaviour
{
    public Text moneyText;
    string money;

    readonly string URL = "http://10.80.162.103:8000";
    void Start()
    {
        moneyText.text = "Dwonloading Money Data...";
    }

    IEnumerator PostRequest(string extraurl, string post)
    {
        List<IMultipartFormSection> wwwForm = new List<IMultipartFormSection>();
        wwwForm.Add(new MultipartFormDataSection("curMoneyKey", post));

        UnityWebRequest www = UnityWebRequest.Post(URL + extraurl, wwwForm);

        yield return www.SendWebRequest();

        if (www.isHttpError || www.isNetworkError)
        {
            Debug.LogError(www.error);
        }

        else
        {
            moneyText.text = www.downloadHandler.text;
        }
    }
    IEnumerator GetRequest(string extraurl)
    {
        UnityWebRequest www = UnityWebRequest.Get(URL + extraurl);

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

    void SignUp(int id, string password, string phoneNum, string birthday, string name, string nickname, string profile, string simplePassword, string gender)
    {

    }

    void Login(int id, string password)
    {

    }

    void Simple_Login(string simplePassword)
    {

    }

    void Duplicate_Check(int id)
    {

    }

    void Self_Certification(string name, string birthday)
    {

    }

    void Account()
    {

    }

    void Account(string name, string passwored)
    {

    }

    void Account_Add()
    {

    }

    void Account_Cofirm(int [] accountnumbers)
    {

    }

    void Account_Money_Send(int money, int sendAccountNumber, int recieveAccountNumber, string bankNumber, string password)
    {

    }

    void Account_Money_Get(int money, int sendAccountNumber, int recieveAccountNumber, string bankNumber, string password)
    {

    }

    void Account(int accountNumber, string password)
    {

    }

    void Stats_Money()
    {

    }

    void Stats_Users()
    {

    }

    void Stats()
    {

    }

    void Stats(int id, string password)
    {

    }

    void Profile()
    {

    }

    void Profile(string profile, string birthday, string name, string nickname, string gender)
    {
        
    }

    void Account_PhoneNumber(string phonenumber)
    {

    }

    void Account(int senderAccount, int recieverAccount, int money)
    {

    }
}
