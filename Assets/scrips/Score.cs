using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class Score : MonoBehaviour
{
    [SerializeField] int iScore;
    [SerializeField] GameObject ScoreText;

    GameObject dg;
    [SerializeField] string Win;

    // Start is called before the first frame update
    void Start()
    {

        dg = GameObject.Find("GlobalData");
        ResetScore();
        ShowScoreInScreen();
    }

    void ShowScoreInScreen()
    {
        int iPuntTemp;
        iPuntTemp = dg.GetComponent<GlobalData>().GetIscore();
        ScoreText.GetComponent<TextMeshProUGUI>().text = iPuntTemp.ToString();

        if (iPuntTemp >= 20)
        {
            SceneManager.LoadScene(Win);
        }

    }

    public void MorePoints(int iZenbatPuntu)
    {
        int iPuntTemp;

        //Jokalariak zituen Puntuak jaso.
        iPuntTemp = dg.GetComponent<GlobalData>().GetIscore();
        //Puntu horiei iZenbatPuntu gehitu.
        iPuntTemp = iPuntTemp + iZenbatPuntu;
        //Gorde behar ditut puntu horiek.
        dg.GetComponent<GlobalData>().SetIscore(iPuntTemp);
        //Pantailatik erakutzi behar ditut puntua horiek.
        ShowScoreInScreen();
    }
    public void ResetScore()
    {
        iScore = 0;
    }

}