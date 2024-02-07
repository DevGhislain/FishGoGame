using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ShowNewLevelBehaviour : MonoBehaviour
{
    #region Public Members

    /// <summary>
    /// Reference for the show the panel
    /// </summary>
    public static bool show = false;

    #endregion

    #region Private Memebers unity

    /// <summary>
    /// Reference for the text
    /// </summary>
    [SerializeField]
    private TextMeshProUGUI LevelText;

    /// <summary>
    /// Reference for the text
    /// </summary>
    [SerializeField]
    private GameObject levelTextObject;

    #endregion

    #region Priavte  Unity Memebers

    private void Update()
    {
      
            showTheLevel(CharacterBehaviour.newLevel);
    }

    #endregion

    #region Private memebers 

    /// <summary>
    /// Method for enabled the panel
    /// </summary>
    /// <param name="_newLevel"></param>
    /// <returns></returns>
    void showTheLevel(int _newLevel)
    {
        string txt = "Level " + _newLevel;
        LevelText.text = txt;
    }

    #endregion
}
