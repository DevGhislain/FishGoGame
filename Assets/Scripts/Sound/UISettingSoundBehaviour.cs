using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UISettingSoundBehaviour : MonoBehaviour
{
    #region Private members

    /// <summary>
    /// Reference of the Rigibody for the character 
    /// </summary>
    [SerializeField]
    private Toggle toggleSound;

    #endregion

    #region Method for the Unity

    private void Awake()
    {
        if (PlayerPrefs.GetInt("AudioValue") != null)
        {
            toggleSound.isOn = Convert.intToBool(PlayerPrefs.GetInt("AudioValue"));
        }
    }

    /// <summary>
    /// Get the first method for Start
    /// </summary>
    private void Start()
    {
        toggleSound.onValueChanged.AddListener(ToggleSound);
    }

    #endregion

    #region Private methods

    /// <summary>
    /// Method for the jump if the click for the button
    /// </summary>
    void ToggleSound(bool _isOn)
    {
        if (_isOn)
        {
            PlayerPrefs.SetInt("AudioValue", 1);
        }
        else
        {
            PlayerPrefs.SetInt("AudioValue", 0);
        }
    }

    /// <summary>
    /// Convert the bool for int
    /// </summary>
    public class Convert
    {
        public static bool intToBool(int Number)
        {
            return (Number == 0 ? false : true);
        }
    }

    #endregion
}
