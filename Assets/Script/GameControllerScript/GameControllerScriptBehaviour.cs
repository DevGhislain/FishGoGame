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
    public GameObject hearth1, hearth2, hearth3, hearth4;

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
    private GameObject uiGameOverPanel;

    /// <summary>
    /// Reference of the UI panel
    /// </summary>
    [SerializeField]
    private GameObject uiLevelPanel;


    /// <summary>
    /// Reference of the UI pause panel
    /// </summary>
    [SerializeField]
    private GameObject uiPauseButton;


    /// <summary>
    /// Reference of Audio Source for the coins Value
    /// </summary>
    private AudioSource backgroundAudioValue;

    /// <summary>
    /// Reference of Audio Source for the coins Value
    /// </summary>
    private AudioSource loseAudioValue;

    /// <summary>
    /// Reference for the advs
    /// </summary>
    private AdvsInitialize advsManager;

    #endregion

    #region Public Accessor Unity

    /// <summary>
    /// Get the first method 
    /// </summary>
    private void Start()
    {
        advsManager = GetComponent<AdvsInitialize>();

        if (Time.timeScale!=1)
        {
            Time.timeScale = 1;
        }
        health = 4;
        hearth1.SetActive(true);
        hearth2.SetActive(true);
        hearth3.SetActive(true);
        hearth4.SetActive(true);

        backgroundAudioValue = GameObject.FindGameObjectWithTag("BackgroudSound").GetComponent<AudioSource>();
        loseAudioValue = GameObject.FindGameObjectWithTag("LoseSound").GetComponent<AudioSource>();
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
                break;

            case 3:
                hearth1.SetActive(false);
                hearth2.SetActive(true);
                hearth3.SetActive(true);
                hearth4.SetActive(true);
                break;
            case 2:
                hearth1.SetActive(false);
                hearth2.SetActive(false);
                hearth3.SetActive(true);
                hearth4.SetActive(true);
                break;
            case 1:
                hearth1.SetActive(false);
                hearth2.SetActive(false);
                hearth3.SetActive(false);
                hearth4.SetActive(true);
                break;

            case 0:
                hearth1.SetActive(false);
                hearth2.SetActive(false);
                hearth3.SetActive(false);
                hearth4.SetActive(false);
                StartCoroutine(MethodsForGameOver());
                //ShowTheUIMenuGameOver();
                break;

        }
 
    }

    #endregion

    #region Priavte Methods

    /// <summary>
    /// Method for enabled the panel
    /// </summary>
    /// <param name="_newLevel"></param>
    /// <returns></returns>
    IEnumerator MethodsForGameOver()
    {
        backgroundAudioValue.Stop();
        uiPauseButton.SetActive(false);
        uiLevelPanel.SetActive(false);
        yield return new WaitForSeconds(1f);

        uiGameOverPanel.SetActive(true);
        loseAudioValue.Play();
        Time.timeScale = 0;

        //advsManager.PlayTheAds();
    }

  
    #endregion
}
