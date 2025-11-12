using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class NextScene : MonoBehaviour
{
    public GameObject OptionMenu;
    
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
    public void ChangeSceneToSchool()
    {
        SceneManager.LoadScene("SchoolLevel");
    }
    public void ChangeSceneToChurch()
    {
        SceneManager.LoadScene("ChurchLevel");
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
    
}
