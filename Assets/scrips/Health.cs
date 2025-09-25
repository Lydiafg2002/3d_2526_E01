using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Health : MonoBehaviour
{
    [SerializeField] Image HealthBar;
    int MaxHealth = 100;
    [SerializeField] string WhatMenu;

    int ActualHealth;
    // Start is called before the first frame update
    void Start()
    {
        ActualHealth = MaxHealth;
        RepresentHealth(0);
    }

    // Update is called once per frame
    void Update()
    {

        if (ActualHealth <= 0)

        {
            SceneManager.LoadScene(WhatMenu);


        }
    }

    public void RepresentHealth(int iZenbat)
    {
        ActualHealth = ActualHealth + iZenbat;
        HealthBar.fillAmount = ((float)ActualHealth) / (float)MaxHealth;



    }




}