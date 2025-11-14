using UnityEngine;

public class GI_GameInstance : MonoBehaviour
{
    public bool bHasFlour = true;
    public bool bHasYeast = false;

    public bool bHasSalt = false;
    public bool bHasWater = false;

    public bool bHasBread = false;

    public bool bHasFlourKey = false;
    public bool bHasSaltKey = false;

    public static GI_GameInstance instance { get; private set; } = null;

    void Awake()
    {
        if(instance == null)
        {
            Debug.Log("GI_Awake_GameInstance Created");
            instance = this;
            DontDestroyOnLoad(this.gameObject);
        }
        else
        {
            Debug.Log("GI_Awake_GameInstance Duplicate Destroyed");
            Destroy(this.gameObject);
        }
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    //Bool setter
    public void SetFlour()
    {
        bHasFlour = true;
        OnGui();
    }

    public void SetYeast()
    {
        bHasYeast = true;
        OnGui();
    }
    
    public void SetSalt()
    {
        bHasSalt = true;
        OnGui();
    }

    public void SetWater()
    {
        bHasWater = true;
        OnGui();
    }

    public void SetBread()
    {
        bHasBread = true;
        OnGui();
    }

    public void SetSaltKey()
    {
        bHasSaltKey = true;
        OnGui();
    }

    public void SetFlourKey()
    {
        bHasFlourKey = true;
        OnGui();
    }

    void OnGui()
    {
<<<<<<< Updated upstream
        GUI.Label(new Rect(0, 0, 100, 100), "Oggetto Raccolto!");
=======
        inventory = myinventory;
        if (inventory != null)
        {
            Debug.Log("Inventory trovata e diversa da nulla");
        }
        else
        {
            Debug.LogError("Inventory non trovato");
        }
>>>>>>> Stashed changes
    }
    //Bool getter
}
