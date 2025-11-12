using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class NextScene : MonoBehaviour
{
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

    public void Exit()
    {
        Application.Quit();
    }
    
}
