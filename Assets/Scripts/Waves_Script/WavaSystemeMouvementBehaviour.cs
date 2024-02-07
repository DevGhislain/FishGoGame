using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WavaSystemeMouvementBehaviour : MonoBehaviour
{


    #region private Accessor Unity

    /// <summary>
    /// Reference of the Character
    /// </summary>
    [SerializeField]
    private GameObject CharacterPosition;

    #endregion

    #region Public Accessor Unity


    /// <summary>
    /// Method principale for the Update
    /// </summary>
    private void Update() 
    {
        transform.position = new Vector3(CharacterPosition.transform.position.x, 0, -10);
    }

    #endregion
}
