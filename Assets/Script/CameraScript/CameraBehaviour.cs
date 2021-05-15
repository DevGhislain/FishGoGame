// Using Unity System
using UnityEngine;

// Script for the Camera
public class CameraBehaviour : MonoBehaviour
{
    #region private Accessor Unity

    /// <summary>
    /// Reference of the Character
    /// </summary>
    private Transform CharacterPosition;

    #endregion

    #region Public Accessor Unity

    /// <summary>
    /// Get the first method for Update
    /// </summary>
    private void Awake()
    {
        CharacterPosition = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
    }


    /// <summary>
    /// Method principale for the Update
    /// </summary>
    private void Update()
    {
        transform.position = new Vector3(CharacterPosition.position.x + 6.0f, 0, -10);
    }

    #endregion
}
