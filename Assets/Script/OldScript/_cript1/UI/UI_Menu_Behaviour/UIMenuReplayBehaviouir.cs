// Using Unity System
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


// Class for the Ui replay

public class UIMenuReplayBehaviouir : MonoBehaviour
{
    #region private Accessor Unity

    /// <summary>
    /// Reference of the button for the button replay
    /// </summary>
    [SerializeField]
    private Button replayBtn;

    #endregion

    #region Method for the Unity

    /// <summary>
    /// Get the first method for Update
    /// </summary>
    private void Awake()
    {
        replayBtn.onClick.AddListener(Replay);
    }

    #endregion


    #region Private Methods

    /// <summary>
    /// void of the replay the Game
    /// </summary>
    void Replay()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(0);
    }

    #endregion

}
