using UnityEngine;
using TMPro;

public class ProductDetailsController : MonoBehaviour
{
    public TMP_Text detailsTitle;
    public TMP_Text detailsText;

    public void ShowLaptopDetails()
    {
        detailsTitle.text = "Laptop Pro 15";

        detailsText.text =
            "Intel Core i7 Processor\n" +
            "16 GB RAM\n" +
            "512 GB SSD\n" +
            "15.6\" Full HD Display\n" +
            "RTX Graphics\n" +
            "Price: Rs. 79,999";
    }

    public void ShowMobileDetails()
    {
        detailsTitle.text = "Samsung S4";

        detailsText.text =
            "5.0\" Super AMOLED Display\n" +
            "2 GB RAM\n" +
            "16 GB Storage\n" +
            "13 MP Main Camera\n" +
            "2600 mAh Battery\n" +
            "Price: Rs. 41,500";
    }

    public void ShowSpeakersDetails()
    {
        detailsTitle.text = "Duo Speakers";

        detailsText.text =
            "Stereo Speaker System\n" +
            "Powerful Bass Output\n" +
            "Bluetooth Connectivity\n" +
            "Wireless Audio Support\n" +
            "Premium Sound Quality\n" +
            "Price: Rs. 5,999";
    }
}