using UnityEngine;
using UnityEngine.UI; // Required for the Button component

public class OpenCustomURLButton : MonoBehaviour
{
    // URL to open when the button is pressed
    public string urlToOpen = "https://www.example.com";  // Default URL (can be changed in Inspector)

    // The UI Button component
    public Button yourButton;

    // Start is called before the first frame update
    void Start()
    {
        // Ensure the button is assigned
        if (yourButton != null)
        {
            // Add listener to the button to call OpenURL when clicked
            yourButton.onClick.AddListener(OpenURL);
        }
        else
        {
            Debug.LogError("Button not assigned! Please assign a button in the Inspector.");
        }
    }

    // This function will be called when the button is clicked
    public void OpenURL()
    {
        // Open the URL provided in the Inspector
        Application.OpenURL(urlToOpen);
    }
}
