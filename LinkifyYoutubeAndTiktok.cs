using UnityEngine;
using UnityEngine.UI; // To use Button component

public class OpenURLButton : MonoBehaviour
{
    // The URL you want to open (can be set in the Inspector)
    public string youtubeURL = ""; // Example YouTube channel URL
    public string tiktokURL = ""; // Example TikTok page URL

    // The UI Button component
    public Button yourButton;

    // Start is called before the first frame update
    void Start()
    {
        // Make sure the button is assigned
        if (yourButton != null)
        {
            // Add a listener to the button to call OpenURL when clicked
            yourButton.onClick.AddListener(OpenURL);
        }
        else
        {
            Debug.LogError("Button not assigned!");
        }
    }

    // This function will be called when the button is pressed
    public void OpenURL()
    {
        // Open YouTube or TikTok URL based on your choice
        // You can also change the URL dynamically, based on user input, etc.
        // Uncomment one of the following lines to open the respective page:

        Application.OpenURL(youtubeURL); // Open YouTube
        // Application.OpenURL(tiktokURL); // Open TikTok
    }
}