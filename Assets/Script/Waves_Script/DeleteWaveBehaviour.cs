//Using Unity System
using UnityEngine;

// Script for the delete the wave
public class DeleteWaveBehaviour : MonoBehaviour
{
    #region Private Methods

    /// <summary>
    /// void for the delete the wave
    /// </summary>
    /// <param name="collision"></param>
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("WavePoint"))
        {
           Destroy( GameObject.FindWithTag("Wave"));
        }
    }

    #endregion

}
