//Using Unity System
using UnityEngine;

public class LoadWaveBehaviour : MonoBehaviour
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
            GameObject.Find("WaveStartPoint").GetComponent<WaveSpawnBehaviour>().SpawnWaves();
        }
    }

    #endregion
}
