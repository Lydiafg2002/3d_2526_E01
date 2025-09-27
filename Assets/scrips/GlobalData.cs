using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobalData : MonoBehaviour
{
    [SerializeField] int iScore;

    public static GlobalData Instance;

    // Start is called before the first frame update
    private void Start()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
            ResetGlobalData();
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void ResetGlobalData()
    {
        iScore = 0;
    }

    public void SetIscore(int ipunti)
    {
        iScore = ipunti;
    }

    public int GetIscore()
    {
        return iScore;
    }


}