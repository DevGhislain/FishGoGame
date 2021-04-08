// Using Unity System
using UnityEngine;

// Class Kill zone behaviour for the kill the players

public class Kill_ZoneBehaviour : MonoBehaviour
{

    #region private Accessor Unity

    /// <summary>
    /// Reference of the button for the Object GameOvers
    /// </summary>
    [SerializeField]
    private GameObject GameOvers;

    /// <summary>
    /// Reference of the button for the Object PauseBtn
    /// </summary>
    [SerializeField]
    private GameObject PauseBtn;

    #endregion


    #region Private Methods

    /// <summary>
    /// Reference of the OnCollisionExit2D for the Kill zone player
    /// </summary>
    /// <param name="collision"></param>
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Character"))
        {
            Time.timeScale = 0;
            GameOvers.SetActive(true);
            PauseBtn.SetActive(false);
        }
    }

    #endregion
}
