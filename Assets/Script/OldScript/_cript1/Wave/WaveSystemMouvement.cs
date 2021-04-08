//Using Unity System
using UnityEngine;

public class WaveSystemMouvement : MonoBehaviour
{
    #region private Accessor Unity

    /// <summary>
    /// Reference of the Character
    /// </summary>
    public GameObject Character;

    #endregion

    #region Public Accessor Unity

    /// <summary>
    /// Method principale for the Update
    /// </summary>
    private void Update()
    {
        transform.position = new Vector3(Character.transform.position.x, 0, -0.2f);
    }

    #endregion

}