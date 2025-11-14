using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class CandleManager : MonoBehaviour
{
    int index; //7
    public GameObject CandleScreen;
    public Sprite spriteOn;
    public Sprite HoveredspriteOn;
    public Sprite spriteOff;
    public Sprite HoveredspriteOff;
    public Button CandelButton;
    public Button Buttonrock;
    public GameObject RockPanel;
       public Button Buttonletter;
    public GameObject letterpanel;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Buttonrock.interactable = false;
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void CandleActivation()
    {
        CandleScreen.SetActive(true);
    }

    public void CandleDisable()
    {
        CandleScreen.SetActive(false);
    }
    public void CandleCountAdd(Button button)
    {
        SpriteState ss = button.spriteState;
        if(button.targetGraphic.GetComponent<Image>().sprite==spriteOff)
        {
            button.targetGraphic.GetComponent<Image>().sprite=spriteOn;
            ss.highlightedSprite = HoveredspriteOn;
            button.spriteState = ss;
            index++;
            CandleCheck();
        }
        else
        {
            button.targetGraphic.GetComponent<Image>().sprite=spriteOff;
            ss.highlightedSprite = HoveredspriteOff;
            button.spriteState = ss;
            index--;
            CandleCheck();
        }
    }

    public void CandleNotAddable(Button button)
    {
        SpriteState ss = button.spriteState;
        if(button.targetGraphic.GetComponent<Image>().sprite==spriteOff)
        {
            button.targetGraphic.GetComponent<Image>().sprite=spriteOn;
            ss.highlightedSprite = HoveredspriteOn;
            button.spriteState = ss;
            index--;
            CandleCheck();
        }
        else
        {
            button.targetGraphic.GetComponent<Image>().sprite=spriteOff;
            ss.highlightedSprite = HoveredspriteOff;
            button.spriteState = ss;
            index++;
            CandleCheck();
        }
    }

    public void CandleCheck()
    {
        if(index==7)
        {
            StartCoroutine(DelayFunction(0.5f,() => CandleScreen.SetActive(false)));
            CandelButton.interactable = false; 
            Buttonrock.interactable = true;
        }
    }
    IEnumerator DelayFunction(float timer, System.Action action)
    {
        yield return new WaitForSeconds(timer);
        action?.Invoke();
    }
    public void RockOn()
    {
        RockPanel.SetActive(true);
    }
     public void RockOff()
    {
        RockPanel.SetActive(false);
    }
     public void LetterOn()
    {
        letterpanel.SetActive(true);
    }
     public void LetterOff()
    {
        letterpanel.SetActive(false);
    }
}
