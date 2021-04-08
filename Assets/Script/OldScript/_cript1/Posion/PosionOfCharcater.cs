// Using Unity System
using UnityEngine;

public class PosionOfCharcater : MonoBehaviour
{
    #region Public Accessor Unity

    /// <summary>
    /// Reference of the Character
    /// </summary>
    public float MaxJumpPossion;

    #endregion


    #region Private Methods

    /// <summary>
    /// 
    /// </summary>
    /// <param name="collision"></param>
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Character"))
        {
            collision.GetComponent<CharacterBehaviour>().isGrounded = false;
            Rigidbody2D rdgb = collision.GetComponent<Rigidbody2D>();
            Vector2 vector2 = rdgb.velocity;
            rdgb.velocity += new Vector2(0, -vector2.y);
            rdgb.velocity += new Vector2(0, MaxJumpPossion);

        }
       
    }

    

    #endregion

}
