// Using Unity System
using System.Collections;
using TMPro;
using UnityEngine;

//Script Attach of the game object Score Amount

public class UIScoreBehaviour : MonoBehaviour
{
    #region private Accessor Unity

    /// <summary>
    /// Reference for the Score multiple in Game
    /// </summary>
    [SerializeField]
    private int ScoreMultiple = 1;

    /// <summary>
    /// Reference for the Score  in Game
    /// </summary>
    [SerializeField]
    private int score = 1;

    /// <summary>
    /// Reference of the Rigibody for the character 
    /// </summary>
    [SerializeField]
    private TextMeshProUGUI textScore;

    #endregion


    #region Private Members

    /// <summary>
    /// Reference for the Current Score  in Game
    /// </summary>
    private int currentScore;


    /// <summary>
    /// Reference for the Best Score  in Game
    /// </summary>
    private int bestScore = 100;

    #endregion



    #region Public  Members

    /// <summary>
    /// Reference for the Current Score  in Game
    /// </summary>
    public int CurrentScore {

        get
        {
            return currentScore;
        }
        set
        {
            currentScore = value;
        }
    }

    #endregion


    #region Method for the Unity

    /// <summary>
    /// Get the first method for Update
    /// </summary>
    private void Start()
    {
    

    }

    /// <summary>
    /// Get the first method for Update
    /// </summary>
    private void Update()
    {
        StartCoroutine("Scoring");
    }

    #endregion

    #region Private Methods

    /// <summary>
    /// 
    /// </summary>
    /// <returns></returns>
    IEnumerator Scoring()
    {
        if (currentScore > PlayerPrefs.GetInt("BestScore") )
        {
            bestScore = currentScore;
            PlayerPrefs.SetInt("BestScore", bestScore);
        }

        yield return new WaitForSeconds(2.0f);
         UpdateScoring(score);

      
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="scoreAdd"></param>
    void UpdateScoring(int scoreAdd)
    {
        currentScore += scoreAdd + ScoreMultiple;
        textScore.text = currentScore + "";
        PlayerPrefs.SetInt("CurrentScore", currentScore);
    }

    #endregion

}


