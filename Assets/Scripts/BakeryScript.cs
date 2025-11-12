using UnityEngine;
using UnityEngine.UI;

public class BakeryScript : MonoBehaviour
{
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

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
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
        Bottone.image.color = colors[i];
        i++;
        if (i == 4)
        {
            i = 0;
        }
        return i;
    }

    public void ColorCheck()
    {
        if(YellowPunt == 0 && RedPunt == 1 && GreenPunt == 2 && BluePunt == 3)
        {
            ColorPuzzle.SetActive(false);
            //GameInstance.SetFlour();
        }
    }
}
