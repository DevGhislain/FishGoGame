// Using Unity System
using System.Collections;
using UnityEngine;

// Script for the Character behaviour
public class CharacterBehaviour : MonoBehaviour
{
    #region private Accessor Unity

    /// <summary>
    /// Reference of the Rigibody for the character 
    /// </summary>
    [SerializeField]
    private Rigidbody2D rigidbody2D;

    /// <summary>
    /// Reference of the vulnerability for the character 
    /// </summary>
    [SerializeField]
    private float vulnerabilityTime = 5.5f;

    /// <summary>
    /// Reference of the Animator 
    /// </summary>
    [SerializeField]
    Animator animator;

    #endregion


    #region Private Members



    /// <summary>
    /// Reference for the character if is grounded
    /// </summary>
    private bool IsGrounded = false;

    #endregion

    #region Public Membres

   /// <summary>
    ///  Get the reference for the rigidbody for the character
    /// </summary>
    public Rigidbody2D rbd2D
    {
        get
        {
            return rigidbody2D;
        }
    }

    /// <summary>
    ///  Get the  reference for the character if is grounded
    /// </summary>
    public bool isGrounded
    {
        set
        {
            IsGrounded = value;
        }

        get
        {
            return IsGrounded;
        }
    }

    /// <summary>
    /// Reference of the speed Character
    /// </summary>
    ///Use the serielzefield
    public float speedForCharacter = 5;

    /// <summary>
    /// Reference of the speed Character
    /// </summary>
    ///Use the serielzefield
    public float MaxJump;

    #endregion

    #region Private members

    [SerializeField]
    private int valueAccelity = 100;

    #endregion

    #region Method for the Unity

    /// <summary>
    /// Get the first method for Update
    /// </summary>
    private void Start()
    {
        SetVelocity(speedForCharacter, 0);
    }

    /// <summary>
    /// Methods principale for the Update
    /// </summary>
    private void Update()
    {
        if (Input.GetKeyDown("space") && IsGrounded )
        {
            JumpCharacter(MaxJump);  
        }
        if (CoinsBehaviour.coinsValue >= valueAccelity)
        {
            valueAccelity += 50;
            speedForCharacter += 1;
        }
    }

    #endregion

    #region Private Methods

    /// <summary>
    /// Method for the Jump Character
    /// </summary>
   public void JumpCharacter(float _valueJumpe)
    {
        rigidbody2D.velocity += new Vector2(0, _valueJumpe);
        IsGrounded = false;
    }

    /// <summary>
    /// Set the velocity
    /// </summary>
    /// <param name="_xVelocity"> X velocioty</param>
    /// <param name="_yVelocity"> Y velocity</param>
    void SetVelocity(float _xVelocity, float _yVelocity)
    {
        rigidbody2D.velocity = new Vector2(_xVelocity, _yVelocity);
    }

    /// <summary>
    /// Reference of the OnCollisionEnter2D for the Plaform
    /// </summary>
    /// <param name="collisionEnterCharcater"></param>
    void OnCollisionEnter2D(Collision2D collisionEnterCharcater)
    {
        if (collisionEnterCharcater.gameObject.CompareTag("platform"))
        {
            IsGrounded = true;
        }
    }

    /// <summary>
    /// Reference of the OnCollisionExit2D for the Obstacle
    /// </summary>
    /// <param name="collision"></param>
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Obstacle"))
        {
           StartCoroutine(GetObstacle());
        }
   
    }

    /// <summary>
    /// Use the Enumerator 
    /// </summary>
    /// <returns></returns>
  IEnumerator GetObstacle()
    {
        // Stop the the player
        animator.SetBool("IsDear", true);
        GameControllerScriptBehaviour.health -= 1;
        yield return new WaitForSeconds(0.1f);
       SetVelocity(speedForCharacter / 2, 0);

        //Attack for the Monster
        //GameObject.FindWithTag("Monster").GetComponent<MonsterBehaviour>().GoCloser();

        // start the player
        yield return new WaitForSeconds(0.5f);
        SetVelocity(speedForCharacter, 0);
        animator.SetBool("IsDear", false);

        // No Attack for the Monster
        //yield return new WaitForSeconds(vulnerabilityTime);
        // GameObject.FindWithTag("Monster").GetComponent<MonsterBehaviour>().GoFurther();

    }
   
    #endregion
}
