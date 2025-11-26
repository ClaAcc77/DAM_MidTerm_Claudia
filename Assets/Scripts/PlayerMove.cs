using UnityEngine;
using UnityEngine.InputSystem;
using static UnityEngine.InputSystem.InputAction;

public class PlayerMove : MonoBehaviour
{
    float verticalMovement = 0;
    public float playerSpeed = 10;
    public InputAction movePlayer1;

    public Rigidbody2D body;

    bool isUpWallPresent;
    bool isDownWallPresent;

    float MaxRangeUp;
    float MaxRangeDown;
    public Transform UpWallCheckTransform;
    public Transform DownWallCheckTransform;
    //public Transform RightWallCheckTransform;
    public Vector2 CheckUpWallSize = new Vector2(0.5f, 0.5f);
    public Vector2 CheckDownWallSize = new Vector2(0.5f, 0.5f);
    //public Vector2 CheckRightWallSize = new Vector2(0.5f, 0.5f);
    public LayerMask WallLayer;

    public void PlayerInput_Move(CallbackContext context)
    {
        //Debug.Log("Funziona");
        verticalMovement = context.ReadValue<Vector2>().y;

    }

    public void PlayerInput_Move2(CallbackContext context2)
    {
        //Debug.Log("Funziona");
        verticalMovement = context2.ReadValue<Vector2>().y;

    }

    public void FixedUpdate()
    {
        GroundCheck();

        if (isUpWallPresent == true)
        {

            if (verticalMovement > MaxRangeUp)
            {
                verticalMovement = MaxRangeUp;
            }
            else
            {
                body.linearVelocityY = verticalMovement * playerSpeed;
            }

            //Debug.Log("Wall");
        }
        else
        {
            body.linearVelocityY = verticalMovement * playerSpeed;

        }

        if (isDownWallPresent == true)
        {
            if (verticalMovement < MaxRangeDown)
            {
                verticalMovement = MaxRangeDown;
            }
            else
            {
                body.linearVelocityY = verticalMovement * playerSpeed;
            }
        }
        else
        {
            body.linearVelocityY = verticalMovement * playerSpeed;
        }

    }

    public void OnDrawGizmos()
    {
        Gizmos.DrawCube(UpWallCheckTransform.position, CheckUpWallSize);
        Gizmos.DrawCube(DownWallCheckTransform.position, CheckDownWallSize);
        //Gizmos.DrawCube(RightWallCheckTransform.position, CheckRightWallSize);
    }

    public void GroundCheck()
    {
        if (Physics2D.OverlapBox(UpWallCheckTransform.position, CheckUpWallSize, 0, WallLayer))
        {
            isUpWallPresent = true;

        }
        else
        {
            isUpWallPresent = false;
        }

        if (Physics2D.OverlapBox(DownWallCheckTransform.position, CheckDownWallSize, 0, WallLayer))
        {
            isDownWallPresent = true;
        }
        else
        {
            isDownWallPresent = false;
        }
    }
}
