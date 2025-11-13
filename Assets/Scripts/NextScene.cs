using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;
using Unity.VisualScripting;

public class NextScene : MonoBehaviour
{
    public GameObject OptionMenu;
    public TMP_InputField passwordInputField;

    public Button CashMachineButton;
    string correctPassword = "Elena";
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void ChangeSceneToSquare()
    {
        SceneManager.LoadScene("SquareLevel");
    }
    public void ChangeSceneToBakery()
    {
        SceneManager.LoadScene("BakeryLevel");
    }
    public void ChangeSceneToWell()
    {
        SceneManager.LoadScene("WellLevel");
    }

    public void MenuOption()
    {
        OptionMenu.SetActive(true);
    }
    public void CLoseOption()
    {
        OptionMenu.SetActive(false);
    }
       public void ChangeSceneToTitle()
    {
        SceneManager.LoadScene("TitleScreen");
    }
    public void Exit()
    {
        Application.Quit();
    }

        public void CheckPassword()
    {
        //passwordInputField.text = passwordInputField.text.Trim().ToUpper();
        Debug.Log(passwordInputField.text);
        if (passwordInputField.text.Trim().ToUpper() == correctPassword.ToUpper())
        {
            OptionMenu.SetActive(false);
            GI_GameInstance.instance.SetSaltKey();
            CashMachineButton.interactable = false;
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


    
}
