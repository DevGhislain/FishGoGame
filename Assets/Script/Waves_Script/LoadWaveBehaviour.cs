//Using Unity System
using UnityEngine;

//Script for the load the wave 
public class LoadWaveBehaviour : MonoBehaviour
{

    #region Private Methods

    /// <summary>
    /// reference for the load the wave 
    /// </summary>
    /// <param name="collision"></param>
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("WavePoint"))
        {
            GameObject.Find("StartWavePoint").GetComponent<WaveSpawnBehaviour>().SpawnWaves(); 
        }
    }

    #endregion
}
