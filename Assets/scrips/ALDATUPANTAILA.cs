using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ALDATUPANTAILA : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void JoanPantailara (string Osoondofinal)
    {
        {
            SceneManager.LoadScene(Osoondofinal);
        }
    }
}
