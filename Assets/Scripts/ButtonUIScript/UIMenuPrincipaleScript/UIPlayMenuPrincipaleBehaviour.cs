// Using Unity System
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

// Script for the play the game
public class UIPlayMenuPrincipaleBehaviour : MonoBehaviour
{
    #region Private Members

    /// <summary>
    /// Reference of the button play 
    /// </summary>
    private Button playButton;


    #endregion

    #region Public Accessor Unity
    /// <summary>
    /// Get the first method 
    /// </summary>
    private void Start()
    {
    }

    /// <summary>
    /// Get the first method for Update
    /// </summary>
    public void Awake()
    {
        playButton = GetComponent<Button>();
        playButton.onClick.AddListener(playGames);
        
    }

    #endregion


    #region Private Methods

    /// <summary>
    /// Show the panel ui
    /// </summary>
    void playGames()
    {
        SceneManager.LoadScene("Scene1");
    }

    #endregion
}
