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
    /// Refernce for the Panel New level
    /// </summary>
    [SerializeField]
    private GameObject panelShowLevel;

    /// <summary>
    /// Reference for the text
    /// </summary>
    private TextMeshProUGUI LevelText;

    #endregion

    #region Priavte  Unity Memebers

    private void Awake()
    {
        LevelText = panelShowLevel.GetComponent<TextMeshProUGUI>();
    }

    private void Update()
    {
        if (show == true)
        {
            StartCoroutine(showTheLevel(CharacterBehaviour.newLevel));
        }
    }

    #endregion

    #region Private memebers 

    /// <summary>
    /// Method for enabled the panel
    /// </summary>
    /// <param name="_newLevel"></param>
    /// <returns></returns>
    IEnumerator showTheLevel(int _newLevel)
    {
        string txt = "Level " + _newLevel;

        panelShowLevel.SetActive(true);
        yield return new WaitForSeconds(3f);
        LevelText.text = txt;
        panelShowLevel.SetActive(false);
        show = false;
    }

    #endregion
}
