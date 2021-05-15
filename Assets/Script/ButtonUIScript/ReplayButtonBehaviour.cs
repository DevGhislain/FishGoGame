// Using Unity System
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

// Script for the the replay de game
public class ReplayButtonBehaviour : MonoBehaviour
{
    #region Private Members

    /// <summary>
    /// Reference of the replay button 
    /// </summary>
    private Button replayButton;


    #endregion

    #region Public Accessor Unity

    /// <summary>
    /// Get the first method for Update
    /// </summary>
    public void Awake()
    {
        replayButton = GetComponent<Button>();
       
        replayButton.onClick.AddListener((RePlayGame));
    }

    #endregion

    #region Private Methods

    /// <summary>
    /// replay the game and desabled the panel ui
    /// </summary>
    void RePlayGame()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("Scene1");
    }

    #endregion
}
