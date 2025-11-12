using UnityEngine;

public class GI_GameInstance : MonoBehaviour
{

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
}
