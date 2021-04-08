//Using Unity System
using UnityEngine;

// Class for desabled the coins if is the Collect
public class CoinsActiveBehaviour : MonoBehaviour
{
    #region Private Members

    /// <summary>
    /// Reference of the coins againt 
    /// </summary>
    [SerializeField]
    private bool isActiveCoins = true;

    #endregion

    #region Method for the Unity

    /// <summary>
    /// Methods principale for the Update
    /// </summary>
    private void Update()
    {
        if (!isActiveCoins)
        {
           gameObject.SetActive(false);
        }
    }

    #endregion
}
