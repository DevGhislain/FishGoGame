// Using Unity System
using UnityEngine;

// Script for the Camera
public class CameraBehaviour : MonoBehaviour
{
    #region private Accessor Unity

    /// <summary>
    /// Reference of the Character
    /// </summary>
    public GameObject Character;

    #endregion

    #region Public Accessor Unity

    /// <summary>
    /// Get the first method for Update
    /// </summary>
    private void Awake()
    {
       
    }


    /// <summary>
    /// Method principale for the Update
    /// </summary>
    private void Update()
    {
        transform.position = new Vector3(Character.transform.position.x + 5.0f, 0, -10);
    }

    #endregion
}
