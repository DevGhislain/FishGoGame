// Using Unity System
using UnityEngine;


public class FootCharacterBehaviour : MonoBehaviour
{
    #region Method for the Unity

    /// <summary>
    /// Methods principale for the Update
    /// </summary>
    private void Update()
    {
        Debug.DrawRay(gameObject.transform.position, transform.TransformDirection(Vector3.down) * 0.2f, Color.blue);
        RaycastHit2D hit = Physics2D.Raycast(gameObject.transform.position, transform.TransformDirection(Vector3.down) * 0.2f);
        if (hit != null && hit.collider.gameObject.CompareTag("platform"))
        {
            hit.collider.isTrigger = false;
        }
    }

    #endregion
}
