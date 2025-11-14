using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;


public class Inventory : MonoBehaviour
{
    public GameObject DropButton;
    public GameObject InventoryObj;


    public Image FlourSlot;
    public Image SaltSlot;
    public Image YeastSlot;
    public Image WaterSlot;
    public Image FlourKeySlot;
    public Image SaltKeySlot;

    public Sprite FlourSprite;
    public Sprite SaltSprite;
    public Sprite YeastSprite;
    public Sprite WaterSprite;
    public Sprite FlourKeySprite;
    public Sprite SaltKeySprite;
    public Sprite BreadSprite;

    public GI_GameInstance GI;

    void Start()
    {
        GI = (GI_GameInstance)FindFirstObjectByType(typeof(GI_GameInstance));
        if(GI != null )
        {
            Debug.Log("GI trovata!");
        }
        else
        {
            Debug.LogError("GI non trovata!");
        }
    }

    void ShowItemInInventory(Image Slot, Sprite Item)
    {
        Slot.sprite = Item;
    }

    public void ControlInventory()
    {
        
        if (GI.bHasFlour)
        {
            ShowItemInInventory(FlourSlot, FlourSprite);
        }
        if (GI.bHasSalt)
        {
            ShowItemInInventory(SaltSlot, SaltSprite);
        }
        if (GI.bHasYeast)
        {
            ShowItemInInventory(YeastSlot, YeastSprite);
        }
        if (GI.bHasWater)
        {
            ShowItemInInventory(WaterSlot, WaterSprite);
        }
        if (GI.bHasSaltKey)
        {
            ShowItemInInventory(SaltKeySlot, SaltKeySprite);
        }
        if (GI.bHasFlourKey)
        {
            ShowItemInInventory(FlourKeySlot, FlourKeySprite);
        }
        if (GI.bHasBread)
        {
            SaltSlot.enabled = false;
            YeastSlot.enabled = false;
            WaterSlot.enabled = false;
            ShowItemInInventory(FlourSlot, BreadSprite);
        }
    }
    public void ShowInventory()
    {
        ControlInventory();
        InventoryObj.SetActive(true);
        DropButton.SetActive(false);
    }
    public void HideInventory()
    {
        DropButton.SetActive(true);
        InventoryObj.SetActive(false);
    }
}
