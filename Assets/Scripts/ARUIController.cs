using UnityEngine;

public class ARUIController : MonoBehaviour
{
    public GameObject canvas;
    public GameObject productPanel;
    public GameObject detailsPanel;

    public void ShowARUI()
    {
        canvas.SetActive(true);

        productPanel.SetActive(true);
        detailsPanel.SetActive(false);
    }

    public void HideARUI()
    {
        canvas.SetActive(false);
    }
}