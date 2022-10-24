using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FishJumpButtonBehaviour : MonoBehaviour
{
    #region private Accessor Unity

    /// <summary>
    /// Reference of the Rigibody for the character 
    /// </summary>
    [SerializeField]
    private CharacterBehaviour Character;

    /// <summary>
    /// Reference of the Rigibody for the character 
    /// </summary>
    [SerializeField]
    private Button JumpButton;

    #endregion

    #region Method for the Unity

    /// <summary>
    /// Methods for the unity
    /// </summary>
    private void Awake()
    {
        JumpButton.onClick.AddListener(Jump);
    }

    #endregion

    /// <summary>
    /// Method for the jump if the click for the button
    /// </summary>
    void Jump()
    {
        if (Character!=null && Character.isGrounded)
        {
            Character.JumpCharacter(Character.MaxJump);
        }
    }
}
