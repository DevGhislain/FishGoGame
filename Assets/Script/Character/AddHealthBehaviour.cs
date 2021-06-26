using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddHealthBehaviour : MonoBehaviour
{
    /// <summary>
    /// Reference of the OnCollisionExit2D for the health
    /// </summary>
    /// <param name="collision"></param>
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            GameControllerScriptBehaviour.health += 1;
            gameObject.SetActive(false);
        }
    }
}
