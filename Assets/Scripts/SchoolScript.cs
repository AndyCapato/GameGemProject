using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class SchoolScript : MonoBehaviour
{
    public GameObject drawerPanel;

    public GameObject clockPanel;
    public TMP_InputField passwordInputField;
    public string correctPassword = "Giulio";
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OpenDrawer()
    {
        drawerPanel.SetActive(true);
        Debug.Log("Drawer method called in SchoolScript.");
    }

    public void CheckPassword()
    {
        passwordInputField.text = passwordInputField.text.Trim();
        if (passwordInputField.text.Trim() == correctPassword)
        {
            drawerPanel.SetActive(false);
            Debug.Log("Correct Password!");
            // Add logic for correct password
        }
        else
        {
            Debug.Log("Incorrect Password!");
            // Add logic for incorrect password
        }
        Debug.Log("Password checked in SchoolScript.");
    }

    public void OpenClock()
    {
        clockPanel.SetActive(true);
        Debug.Log("Drawer method called in SchoolScript.");
    }
    
    public void CheckClock()
    {
        // Implement clock checking logic here
        Debug.Log("Clock checked in SchoolScript.");
    }

}
