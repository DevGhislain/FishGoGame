// Using Unity System
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

// Class for the Ui Menu

public class UIMenuManager : MonoBehaviour
{

    #region private Accessor Unity

    /// <summary>
    /// Reference of the GameObject for the Object pause 
    /// </summary>
    [SerializeField]
    private GameObject pauseObject;


    /// <summary>
    /// Reference of the button for the Object play
    /// </summary>
    [SerializeField]
    private GameObject playObject;


    /// <summary>
    /// Reference of the button for the Object play
    /// </summary>
    [SerializeField]
    private GameObject ScoreObject;

    /// <summary>
    /// Reference of the button for the button pause 
    /// </summary>
    [SerializeField]
    private Button pauseBtn;


    /// <summary>
    /// Reference of the button for the button play
    /// </summary>
    [SerializeField]
    private Button playBtn;


    #endregion

    #region Private Members

    /// <summary>
    /// Reference of UI pause 
    /// </summary>
    private bool isPause = false;

    #endregion

    #region Method for the Unity

    /// <summary>
    /// Get the first method for Update
    /// </summary>
    private void Awake()
    {
        pauseBtn.onClick.AddListener(PlayPause);
        playBtn.onClick.AddListener(PlayPause);
    }

    #endregion

    #region Private Methods

    /// <summary>
    /// void of the play or pause games 
    /// </summary>
    void PlayPause()
    {
        if (!isPause)
        {
            isPause = true;
            Time.timeScale = 0;
            pauseObject.SetActive(false);
            playObject.SetActive(true);
            ScoreObject.SetActive(false);

        }
        else
        {
            isPause = false;
            Time.timeScale = 1;
            pauseObject.SetActive(true);
            playObject.SetActive(false);
            ScoreObject.SetActive(true);
        }
    }

    #endregion
}
