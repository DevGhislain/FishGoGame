//using unityEngine
using UnityEngine;
using UnityEngine.TextCore.Text;
using UnityEngine.UI;

public class UIMenuNextSelectionBehaviour : MonoBehaviour
{
    #region Private members

    /// <summary>
    /// Reference of the GameObect next Page
    /// </summary>
    [SerializeField]
    private GameObject nextPage;

    /// <summary>
    /// Reference of the GameObect previous Page
    /// </summary>
    [SerializeField]
    private GameObject previousPage;

    /// <summary>
    /// Reference of the Rigibody for the character 
    /// </summary>
    [SerializeField]
    private Button buttonClick;

    #endregion


    #region Method for the Unity

    /// <summary>
    /// Methods for the unity
    /// </summary>
    private void Awake()
    {

        buttonClick.onClick.AddListener(NextPage);
    }

    #endregion

    #region Private methods

    /// <summary>
    /// Method for the jump if the click for the button
    /// </summary>
    void NextPage()
    {
        nextPage.SetActive(true);
        previousPage.SetActive(false);
    }

   #endregion  
}



