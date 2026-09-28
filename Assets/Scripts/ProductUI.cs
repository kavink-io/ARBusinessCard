using UnityEngine;

public class ProductUI : MonoBehaviour
{
    public GameObject productPanel;
    public GameObject detailsPanel;

    public void ShowDetails()
    {
        productPanel.SetActive(false);
        detailsPanel.SetActive(true);
    }

    public void HideDetails()
    {
        detailsPanel.SetActive(false);
        productPanel.SetActive(true);
    }
}