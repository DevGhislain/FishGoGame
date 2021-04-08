// Using Unity System
using UnityEngine;
using TMPro;

public class UIGameOverStatBestCoins : MonoBehaviour
{

    #region private Accessor Unity

    /// <summary>
    /// Reference of the GameObject for the Coins 
    /// </summary>
    [SerializeField]
    private TextMeshProUGUI UICoinsValueText;


    /// <summary>
    /// Reference of the GameObject for the Coins 
    /// </summary>
    [SerializeField]
    private TextMeshProUGUI UIBestCoinsValueText;

    #endregion

    #region Private Members

    /// <summary>
    /// Reference of the coins againt 
    /// </summary>
    private int UICoinsValue;

    /// <summary>
    /// Reference of the coins againt 
    /// </summary>
    private int UIcoinsAmountBest ;

    #endregion

    #region Method for the Unity

    /// <summary>
    /// Get the first method for Update
    /// </summary>
    private void Awake()
    {
        GetTheCoinsStats();
    }

    #endregion

    #region Private Methods

    /// <summary>
    /// 
    /// </summary>
    void GetTheCoinsStats()
    {
        UICoinsValue = PlayerPrefs.GetInt("CoinsAmount");
        UICoinsValueText.text = UICoinsValue.ToString();

        UIcoinsAmountBest = PlayerPrefs.GetInt("CoinsAmountBest");
        UIBestCoinsValueText.text = UIcoinsAmountBest.ToString();
    }

    #endregion

}
