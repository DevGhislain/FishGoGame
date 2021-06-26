using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//Controller of the Game 
public class GameControllerScriptBehaviour : MonoBehaviour
{
    #region Public  Members

    /// <summary>
    /// Reference of different for live the players
    /// </summary>
    public GameObject hearth1, hearth2, hearth3, hearth4, gameOver;

    /// <summary>
    /// Reference of the live of players
    /// </summary>
    public static int health;

    #endregion

    #region Public  Members

    /// <summary>
    /// Reference of the UI panel
    /// </summary>
    [SerializeField]
    private GameObject uiReplayPanel, uiMenuPanel, pauseUIPanel;

    #endregion

    #region Public Accessor Unity

    /// <summary>
    /// Get the first method 
    /// </summary>
    private void Start()
    {
        if (Time.timeScale!=1)
        {
            Time.timeScale = 1;
        }
        health = 4;
        hearth1.SetActive(true);
        hearth2.SetActive(true);
        hearth3.SetActive(true);
        hearth4.SetActive(true);
        gameOver.SetActive(false);
    }


    /// <summary>
    /// Method principale for the Update
    /// </summary>
    private void Update()
    {
        if(health > 4)
        {
            health = 4;
        }
        switch (health)
        {
            case 4:
                hearth1.SetActive(true);
                hearth2.SetActive(true);
                hearth3.SetActive(true);
                hearth4.SetActive(true);
                gameOver.SetActive(false);
                break;

            case 3:
                hearth1.SetActive(false);
                hearth2.SetActive(true);
                hearth3.SetActive(true);
                hearth4.SetActive(true);
                gameOver.SetActive(false);
                break;
            case 2:
                hearth1.SetActive(false);
                hearth2.SetActive(false);
                hearth3.SetActive(true);
                hearth4.SetActive(true);
                gameOver.SetActive(false);
                break;
            case 1:
                hearth1.SetActive(false);
                hearth2.SetActive(false);
                hearth3.SetActive(false);
                hearth4.SetActive(true);
                gameOver.SetActive(false);
                break;

            case 0:
                hearth1.SetActive(false);
                hearth2.SetActive(false);
                hearth3.SetActive(false);
                hearth4.SetActive(false);
                gameOver.SetActive(true);
                Time.timeScale = 0;
                ShowTheUIMenuGameOver();
                break;

        }
    }

    #endregion

    #region Priavte Methods

    /// <summary>
    /// void of the show the UI menu 
    /// </summary>
    void ShowTheUIMenuGameOver()
    {
        uiReplayPanel.SetActive(true);
        uiMenuPanel.SetActive(true);
        pauseUIPanel.SetActive(false);
    }

  

    #endregion
}
