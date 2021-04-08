// Using Unity System
using UnityEngine;
using TMPro;

// Script for the the different Coins
public class CoinsBehaviour : MonoBehaviour
{
    #region private Accessor Unity

    /// <summary>
    /// Reference of the GameObject for the Coins 
    /// </summary>
    [SerializeField]
    private GameObject CoinsGameObject;

    /// <summary>
    /// Reference of the GameObject for the Coins 
    /// </summary>
    //[SerializeField]
    //private TextMeshProUGUI UICoinsValueText;

    /// <summary>
    /// Reference of the Value for the Coins 
    /// </summary>
    [SerializeField]
    private int valueOfCoins;

    /// <summary>
    /// Reference of the Animator 
    /// </summary>
    //[SerializeField]
    //Animator animator;

    #endregion

    #region Private Members

    /// <summary>
    /// Reference of the coins againt 
    /// </summary>
    private int CoinsValue;

    /// <summary>
    /// Reference of the coins againt 
    /// </summary>
    //private int coinsAmountBest = 5;

    #endregion

    #region Public Accessor Unity

    /// <summary>
    /// Get the first method for Update
    /// </summary>
    private void Awake()
    {

      //  UICoinsValueText = GameObject.Find("UI_Coins_Amount_Value").GetComponent<TextMeshProUGUI>();

    }

    #endregion

    #region Private Methods

    /// <summary>
    /// Reference of the OnTriggerEnter2D
    /// </summary>
    /// <param name="collisionEnterCoins2D"></param>
    void OnTriggerEnter2D(Collider2D collisionEnterCoins2D)
    {
        if (collisionEnterCoins2D.gameObject.CompareTag("Player"))
        {

            CoinsGameObject.SetActive(false);

           /* CoinsValue = int.Parse(UICoinsValueText.text) + valueOfCoins;
            PlayerPrefs.SetInt("CoinsAmount", CoinsValue);
            UICoinsValueText.text = CoinsValue.ToString();

            if (animator != null)
            {
                animator.SetBool("IsCollect", true);
            }
            coinsAmountBest = PlayerPrefs.GetInt("CoinsAmountBest");
            if (CoinsValue > coinsAmountBest)
            {
                coinsAmountBest = CoinsValue;
                PlayerPrefs.SetInt("CoinsAmountBest", coinsAmountBest);
            }
          */
        }
    }

    #endregion


}

