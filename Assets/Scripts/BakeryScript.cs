using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.Collections;

public class BakeryScript : MonoBehaviour
{
    public GI_GameInstance gameInstance;
    //Variabili colori
    public GameObject ColorPuzzle;
    public Button CPButton;
    public Button CPQuit;
    public Color[] colors;
    public Button YellowBtt;
    public int YellowPunt = 0;
    public Button RedBtt;
    public int RedPunt = 0;
    public Button GreenBtt;
    public int GreenPunt = 0;
    public Button BlueBtt;
    public int BluePunt = 0;

    //Vault
    public GameObject VaultPuzzle;
    public TextMeshProUGUI Numbers;
    public int VaultCount = 0;
    public Button VaultButton;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //Game instance
        gameInstance = (GI_GameInstance)FindFirstObjectByType(typeof(GI_GameInstance));
        //gameInstance.TestGI();
        //Color
        colors = new Color[]
        {
            Color.red,
            Color.green,
            Color.blue,
            Color.yellow,
        };
    }

    // Update is called once per frame
    void Update()
    {

    }
    //COLOR PUZZLE
    public void SetOnColor()
    {
        ColorPuzzle.SetActive(true);      
    }
    public void SetOffColor()
    {
        ColorPuzzle.SetActive(false);
    }

    //Color button presser

    public void YellowButtonPressd()
    {
        YellowPunt = ChangeButtonColor(YellowBtt, YellowPunt);
        ColorCheck();
    }

    public void RedButtonPressd()
    {
        RedPunt = ChangeButtonColor(RedBtt, RedPunt);
        ColorCheck();
    }

    public void GreenButtonPressd()
    {
        GreenPunt = ChangeButtonColor(GreenBtt, GreenPunt);
        ColorCheck();
    }
    
    public void BlueButtonPressd()
    {
        BluePunt = ChangeButtonColor(BlueBtt, BluePunt);
        ColorCheck();
    }

    //Set Color

    public int ChangeButtonColor(Button Bottone, int i)
    {
        if( i > -1 && i < 4)
        {
            Bottone.image.color = colors[i];
        }
        i++;
        if (i == 4)
        {
            i = 0;
        }
        return i;
    }

    public void ColorCheck()
    {
        if (YellowPunt == 0 && RedPunt == 1 && GreenPunt == 2 && BluePunt == 3)
        {
            StartCoroutine(DelayFunction(0.5f,() => ColorPuzzle.SetActive(false)));
            //ColorPuzzle.SetActive(false);
            gameInstance.SetFlour();
            CPButton.interactable = false;
            Debug.Log("Hai ottenuto Chiave farina");
        }
    }
    
    //Flour

    public void FlourCheck()
    {
        if (gameInstance.bKayFlour)
        {
            Debug.Log("Hai Ottenuto grano");
        }
        else
        {
            Debug.Log("Serve Chiave");
        }
    }

    //Vault function

    public void SetOnVault()
    {
        VaultPuzzle.SetActive(true);      
    }
    public void SetOffVault()
    {
        VaultPuzzle.SetActive(false);
    }

    public void NButton1()
    {
        if(VaultCount==0)
        {
            VaultCount=1;
        }
        SetVaultTextBox();
    }

    public void NButton3()
    {
        if(VaultCount==3)
        {
            VaultCount=4;
        }
        SetVaultTextBox();
    }

    public void NButton9()
    {
        switch (VaultCount)
        {
            case 1: 
            VaultCount=2;
            break;
            case 2:
            VaultCount=3;
            break;
        }
        SetVaultTextBox();
    }

    public void NButtonOther()
    {
        SetVaultTextBox();
    }

    public void SetVaultTextBox()
    {
        string Control = Numbers.text.ToString();

        switch (Control)
        {
            case "":
            Numbers.text = "*";
            break;
            case "*":
            Numbers.text = "**";
            break;
            case "**":
            Numbers.text = "***";
            break;
            case "***":
            Numbers.text = "****";
            StartCoroutine(DelayFunction(0.5f, () => Numbers.text = ""));
            VaultCheck();
            break;
        }
    }

    /*public void SequenzButton(int i)
    {
        switch (VaultCount)
        {
            case 0:
            VaultCount = 1;
            break;
            case 1:
            VaultCount = 2;
            break;
            case 2:
            VaultCount = 3;
            break;
            case 3:
            VaultCount = 4;
            VaultCheck();
            break;
        }
        Debug.Log(VaultCount);
    }*/

    public void VaultCheck()
    {
        if(VaultCount==4)
        {
            Debug.Log("Is Open");
            StartCoroutine(DelayFunction(0.5f,() => VaultPuzzle.SetActive(false)));
            VaultButton.interactable=false;
            GI_GameInstance.instance.SetYeast();
        }
        else
        {
            VaultCount=0;
        }
    }

    //Delay

    public IEnumerator DelayFunction(float timer, System.Action action)
    {
        yield return new WaitForSeconds(timer);
        action?.Invoke();
    }
}