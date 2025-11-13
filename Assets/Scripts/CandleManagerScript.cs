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
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
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
        }
    }
    IEnumerator DelayFunction(float timer, System.Action action)
    {
        yield return new WaitForSeconds(timer);
        action?.Invoke();
    }
}
