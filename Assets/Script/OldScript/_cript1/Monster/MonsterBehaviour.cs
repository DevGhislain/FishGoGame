//Using Unity System
using TMPro;
using UnityEngine;

// Class for the Attack the player
public class MonsterBehaviour : MonoBehaviour
{
    #region private Accessor Unity

    /// <summary>
    /// Reference of the GameObject for the Player 
    /// </summary>
    [SerializeField]
    private GameObject playerCharacter;

    /// <summary>
    /// Reference of the GameObject for the Ennemie 
    /// </summary>
    [SerializeField]
    private GameObject ennemieCharacter;

    /// <summary>
    /// Reference of the button for the Object GameOvers
    /// </summary>
    [SerializeField]
    private GameObject GameOvers;

    /// <summary>
    /// Reference of the button for the Object GameCoins
    /// </summary>
    [SerializeField]
    private GameObject GameCoins;

    /// <summary>
    /// Reference of the button for the Object GameScore
    /// </summary>
    [SerializeField]
    private GameObject GameScore;

    /// <summary>
    /// Reference of the button for the Object PauseBtn
    /// </summary>
    [SerializeField]
    private GameObject PauseBtn;

    /// <summary>
    /// Reference of the Animator for the Ennemie 
    /// </summary>
    [SerializeField]
    private Animator monsterAnimator;

    /// <summary>
    /// Reference of the Game object of the score current
    /// </summary>
    [SerializeField]
    private GameObject PopUpScoreCurrent ;

    /// <summary>
    /// Reference of the Game object of the score current
    /// </summary>
    [SerializeField]
    private TextMeshProUGUI PopUpScoreCurrentText;

    /// <summary>
    /// Reference of the Game object of the score best
    /// </summary>
    [SerializeField]
    private GameObject PopUpScoreBest;

    /// <summary>
    /// Reference of the Game object of the score best text
    /// </summary>
    [SerializeField]
    private TextMeshProUGUI PopUpScoreBestText;

    #endregion

    #region private Accessor Unity

    /// <summary>
    /// Reference of the state for monster
    /// </summary>
    private int state = 0;

    #endregion


    #region Method for the Unity

    /// <summary>
    /// Get the first method for Update
    /// </summary>
    private void Update()
    {
        ennemieCharacter.transform.position = new Vector3(playerCharacter.transform.position.x - 5, playerCharacter.transform.position.y - 0.5f, -5);
    }

    #endregion

    #region Public Methods


    /// <summary>
    ///  Void of the no Attack the plyer
    /// </summary>
    public void GoFurther()
    {
        state--;
        monsterAnimator.SetInteger("State", state);
    }

    /// <summary>
    /// Void of the Attack the plyer
    /// </summary>
    public void GoCloser()
    {
        state++;
        monsterAnimator.SetInteger("State", state);
    }

    /// <summary>
    /// Reference of the OnCollisionExit2D for the Obstacle
    /// </summary>
    /// <param name="collision"></param>
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Character"))
        {
         
            Time.timeScale = 0;
            GameOvers.SetActive(true);
            PauseBtn.SetActive(false);
            GameCoins.SetActive(false);
            GameScore.SetActive(false);

            if (PlayerPrefs.GetInt("BestScore") < PlayerPrefs.GetInt("CurrentScore"))
            {
                PopUpScoreBest.SetActive(true);
                PopUpScoreBestText.text = PlayerPrefs.GetInt("BestScore") + "";

            }
            else
            {
              PopUpScoreCurrent.SetActive(true);
                PopUpScoreCurrentText.text = PlayerPrefs.GetInt("CurrentScore") + "";
            }
        }
    }

    #endregion

}
