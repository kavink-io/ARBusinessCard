using UnityEngine;
using TMPro;

public class ProductInfoController : MonoBehaviour
{
    public TMP_Text productName;
    public TMP_Text price;
    public TMP_Text description;

    public void ShowLaptopInfo()
    {
        productName.text = "Laptop Pro 15";
        price.text = "Rs. 79,999";
        description.text = "Powerful performance for work, gaming and everyday productivity.";
    }

    public void ShowMobileInfo()
    {
        productName.text = "Samsung S4";
        price.text = "Rs. 41,500";
        description.text = "Premium smartphone with powerful performance and an advanced camera.";
    }

    public void ShowSpeakersInfo()
    {
        productName.text = "Duo Speakers";
        price.text = "Rs. 5,999";
        description.text = "Premium stereo speakers delivering immersive and powerful sound.";
    }
}