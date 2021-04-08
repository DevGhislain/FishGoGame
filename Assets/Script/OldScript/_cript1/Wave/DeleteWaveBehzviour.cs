//Using Unity System
using UnityEngine;

public class DeleteWaveBehzviour : MonoBehaviour
{
    #region Private Methods

    /// <summary>
    /// 
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
