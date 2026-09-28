using UnityEngine;
using UnityEngine.UI;

public class ProductCatalogue : MonoBehaviour
{
    public GameObject laptop;
    public GameObject mobile;
    public GameObject speakers;

    public Button laptopButton;
    public Button mobileButton;
    public Button speakersButton;

    public void ShowLaptop()
    {
        laptop.SetActive(true);
        mobile.SetActive(false);
        speakers.SetActive(false);

        SelectButton(laptopButton);
    }

    public void ShowMobile()
    {
        laptop.SetActive(false);
        mobile.SetActive(true);
        speakers.SetActive(false);

        SelectButton(mobileButton);
    }

    public void ShowSpeakers()
    {
        laptop.SetActive(false);
        mobile.SetActive(false);
        speakers.SetActive(true);

        SelectButton(speakersButton);
    }

    private void SelectButton(Button selectedButton)
    {
        laptopButton.interactable = true;
        mobileButton.interactable = true;
        speakersButton.interactable = true;

        selectedButton.interactable = false;
    }
}