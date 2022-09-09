// Using Unity System
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

//Load the Menu scenes 
public class UIMenuBehaviour : MonoBehaviour
{
    #region Private Members

    /// <summary>
    /// Reference of the coins againt 
    /// </summary>
    
    private Button MenulUIButton;


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
        MenulUIButton = GetComponent<Button>();
        MenulUIButton.onClick.AddListener((ShowTheMenuPrincipalButton));
    }

    #endregion

    #region Private Methods

    /// <summary>
    /// Show the panel ui
    /// </summary>
    void ShowTheMenuPrincipalButton()
    {
        if (Time.timeScale != 1)
        {
            Time.timeScale = 1;
        }
        SceneManager.LoadScene("ScenesMenu");
    }

    #endregion
}


