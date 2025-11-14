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

    public GameObject inventory;
    GI_GameInstance GI;

    void Awake()
    {
        GI = (GI_GameInstance)FindFirstObjectByType(typeof(GI_GameInstance));
<<<<<<< Updated upstream
=======
        Debug.Log("GameInstance cercata");
        if (GI == null)
            Debug.LogError("GameInstance non trovata");
        GI.SetInventory(this);
>>>>>>> Stashed changes
    }

    void ShowItemInInventory(Image Slot, Sprite Item)
    {
        Slot.sprite = Item;
    }

    public void ControlInventory()
    {
        SetUIActive(inventory);
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
<<<<<<< Updated upstream
    public void ShowInventory()
    {
        InventoryObj.SetActive(true);
        DropButton.SetActive(false);
    }
    public void HideInventory()
    {
        DropButton.SetActive(true);
        InventoryObj.SetActive(false);
=======

    public void SetUIActive(GameObject ui)
    {
        ui.SetActive(true);
    }

    public void SetUINotActive(GameObject ui)
    {
        ui.SetActive(false);
>>>>>>> Stashed changes
    }
}
