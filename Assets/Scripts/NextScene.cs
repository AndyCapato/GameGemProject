using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;
using Unity.VisualScripting;
using System.Collections;
using UnityEngine.Video;

public class NextScene : MonoBehaviour
{
    public GameObject OptionMenu;
    //public AudioClip audioClip;
    public AudioSource audioComponenmt;
    public TMP_InputField passwordInputField;
    public Button CounterBTN;

    public VideoPlayer videoPlayer;

    public GameObject rawImageVideo;
    
    string correctPassword = "Elena";

    public Inventory inventory;
    
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
        StartCoroutine(DelayFunction(1,() =>SceneManager.LoadScene("SquareLevel")));
    }
    public void ChangeSceneToBakery()
    {
        StartCoroutine(DelayFunction(1,() =>SceneManager.LoadScene("BakeryLevel")));
    }
    public void ChangeSceneToWell()
    {
        StartCoroutine(DelayFunction(1,() =>SceneManager.LoadScene("WellLevel")));
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
            CounterBTN.interactable=false;
            PlayAudio();
            GI_GameInstance.instance.SetSaltKey();
            Debug.Log("Correct Password!");
            inventory.ControlInventory();
            TempInventoryPopup();
            // Add logic for correct password
        }
        else
        {
            Debug.Log("Incorrect Password!");
            // Add logic for incorrect password
        }
        Debug.Log("Password checked in SchoolScript.");
    }

    public void PlayAudio()
    {
        audioComponenmt.Play();
    }

    public void PlayVideo()
    {
        rawImageVideo.SetActive(true);
        videoPlayer.Play();
        StartCoroutine(DelayFunction(2.5f,() =>SceneManager.LoadScene("SquareLevel")));
    }
     public IEnumerator DelayFunction(float timer, System.Action action)
    {
        yield return new WaitForSeconds(timer);
        action?.Invoke();
    }

    public void TempInventoryPopup()
    {
        StartCoroutine(DelayFunction(1.0f, () => inventory.ShowInventory()));
        StartCoroutine(DelayFunction(2.5f, () => inventory.HideInventory()));
    }


}
