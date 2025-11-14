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
    }

    public void SetYeast()
    {
        bHasYeast = true;
    }
    
    public void SetSalt()
    {
        bHasSalt = true;
    }

    public void SetWater()
    {
        bHasWater = true;
    }

    public void SetBread()
    {
        bHasBread = true;
    }

    public void SetSaltKey()
    {
        bHasSaltKey = true;
    }

    public void SetFlourKey()
    {
        bHasFlourKey = true;
    }

    //Bool getter
}
