//Using Unity System
using UnityEngine;

public class WaveSpawnBehaviour : MonoBehaviour
{
    #region private Accessor Unity

    /// <summary>
    /// Reference of the Character
    /// </summary>
    public GameObject[] Waves;

    #endregion

    #region Public Accessor Unity

    /// <summary>
    /// Get the first method for Update
    /// </summary>
    private void Awake()
    {
        SpawnWaves();

    }

    #endregion

    #region Private Methods

    /// <summary>
    /// Spawn the different waves in games 
    /// </summary>
    public void SpawnWaves()
    {
        if (Waves.Length != 0)
        { 
            Instantiate(Waves[Random.Range(0, Waves.Length)], new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, 0), Quaternion.identity);
        }
    }

    #endregion

}
