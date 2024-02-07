// Using Unity System
using UnityEngine;
using TMPro;
using UnityEngine.UI;


// Script for the active the play
public class PlayButtonBehaviour : MonoBehaviour
{
    #region private Accessor Unity

    /// <summary>
    /// Reference of the GameObject for the Pause panel 
    /// </summary>
    [SerializeField]
    private GameObject pauselUI;


    /// <summary>
    /// Reference of the GameObject for the UI panel 
    /// </summary>
    [SerializeField]
    private GameObject uIMenuPanel;

    #endregion

    #region Private Members

    /// <summary>
    /// Reference of the play button 
    /// </summary>
    private Button playButton;


    #endregion

    #region Public Accessor Unity

    /// <summary>
    /// Get the first method for Update
    /// </summary>
    private void Awake()
    {
        playButton = GetComponent<Button>();
        playButton.onClick.AddListener((PlayGame));
    }

    #endregion

    #region Private Methods

    /// <summary>
    /// play the game and desabled the panel ui
    /// </summary>
    void PlayGame()
    {
        Time.timeScale = 1;
        uIMenuPanel.SetActive(false);
    }

    #endregion
}
