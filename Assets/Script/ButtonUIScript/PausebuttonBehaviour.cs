// Using Unity System
using UnityEngine;
using TMPro;
using UnityEngine.UI;


// Script for the active the Pause button panel 
public class PausebuttonBehaviour : MonoBehaviour
{
    #region private Accessor Unity

    /// <summary>
    /// Reference of the GameObject for the UI panel 
    /// </summary>
    [SerializeField]
    private GameObject uIPlayPanel, uIReplayPanel, uIMenuPanel;

    /// <summary>
    /// Reference of the GameObject for the Pause panel 
    /// </summary>
    [SerializeField]
    private GameObject pauselUI;

    #endregion

    #region Private Members

    /// <summary>
    /// Reference of the coins againt 
    /// </summary>
    private Button pauseButton;


    #endregion

    #region Public Accessor Unity

    /// <summary>
    /// Get the first method for Update
    /// </summary>
    public void Awake()
    {
        pauseButton = GetComponent<Button>();
        pauseButton.onClick.AddListener((ShowThePanelPauseButton));
    }

    #endregion

    #region Private Methods

    /// <summary>
    /// Show the panel ui
    /// </summary>
    void ShowThePanelPauseButton()
    {
        Time.timeScale = 0;
        uIPlayPanel.SetActive(true);
        uIReplayPanel.SetActive(true);
        uIMenuPanel.SetActive(true);
        pauselUI.SetActive(false);
    }

    #endregion
}
