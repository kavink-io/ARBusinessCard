using UnityEngine;

public class ContactController : MonoBehaviour
{
    public string phoneNumber = "+919999999999";
    public string emailAddress = "example@techzone.com";
    public string websiteURL = "https://example.com";
    public string mapURL = "https://maps.google.com";

    public void CallBusiness()
    {
        Application.OpenURL("tel:" + phoneNumber);
    }

    public void OpenEmail()
    {
        Application.OpenURL("mailto:" + emailAddress);
    }

    public void OpenWebsite()
    {
        Application.OpenURL(websiteURL);
    }

    public void OpenLocation()
    {
        Application.OpenURL(mapURL);
    }
}