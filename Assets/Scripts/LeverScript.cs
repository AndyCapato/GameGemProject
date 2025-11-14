using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.Collections;

public class LeverScript : MonoBehaviour
{
    public GameObject LevelPanel;
    public Button LeverButton;  
    public GameObject LeverImage;
    public int LeverIndex = 0;
    public int GlobalIndex = 0;

    public void  RotateRight()
    {
        LeverImage.transform.eulerAngles = new Vector3 ( LeverImage.transform.eulerAngles.x,LeverImage.transform.eulerAngles.y,LeverImage.transform.eulerAngles.z - 90);
        switch(LeverIndex)
        {
            case 0: 
            LeverIndex = 1;
            break;

            case 1:
            LeverIndex = 2;
            break; 

            case 2:
            LeverIndex = 3;
            break;

        }
        Debug.Log(LeverIndex);
        GlobalIndex ++;
        IndexCheck();

    }
    public void RotateLeft()
    {
        LeverImage.transform.eulerAngles = new Vector3 ( LeverImage.transform.eulerAngles.x,LeverImage.transform.eulerAngles.y,LeverImage.transform.eulerAngles.z + 90);

        if(LeverIndex ==3)
        {
            LeverIndex = 4;
        }
        Debug.Log(LeverIndex);
        GlobalIndex ++;
        IndexCheck();
    }

    public void IndexCheck()
    {
        if(GlobalIndex ==4)
        {
           if(LeverIndex ==4)
            {
                Debug.Log("Risolto");
                StartCoroutine(DelayFunction(0.5f,()=> SetOff()));
                LeverButton.interactable=false;
            }
            else
            {
                Debug.Log("Hai Sbagliato Coglione");
                StartCoroutine(DelayanimFunction());
                GlobalIndex = 0;
                LeverIndex = 0;
            }
        }
    }

    public IEnumerator DelayanimFunction()
    {
        LeverImage.transform.eulerAngles = new Vector3 ( LeverImage.transform.eulerAngles.x,LeverImage.transform.eulerAngles.y,-37);
        yield return new WaitForSeconds(0.5f);
        LeverImage.transform.eulerAngles = new Vector3 ( LeverImage.transform.eulerAngles.x,LeverImage.transform.eulerAngles.y,LeverImage.transform.eulerAngles.z - 90);
        yield return new WaitForSeconds(0.3f);
        LeverImage.transform.eulerAngles = new Vector3 ( LeverImage.transform.eulerAngles.x,LeverImage.transform.eulerAngles.y,LeverImage.transform.eulerAngles.z - 90);
        yield return new WaitForSeconds(0.3f);
        LeverImage.transform.eulerAngles = new Vector3 ( LeverImage.transform.eulerAngles.x,LeverImage.transform.eulerAngles.y,LeverImage.transform.eulerAngles.z - 90);
        yield return new WaitForSeconds(0.3f);
        LeverImage.transform.eulerAngles = new Vector3 ( LeverImage.transform.eulerAngles.x,LeverImage.transform.eulerAngles.y,LeverImage.transform.eulerAngles.z - 90);
        yield return new WaitForSeconds(0.3f);
    }

    public void SetOn()
    {
        LevelPanel.SetActive(true);
    }

    public void SetOff()
    {
        LevelPanel.SetActive(false);
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public IEnumerator DelayFunction(float timer, System.Action action)
    {
        yield return new WaitForSeconds(timer);
        action?.Invoke();
    }
}
