using UnityEngine;

public enum Direction
{
    Left,
    Right
}

public class Mover : MonoBehaviour
{
    public void Move(Direction direction, float speed, Rigidbody2D actorRigidbody)
    {
        Vector2 moveVector = MakeMoveVector(direction, speed);
        actorRigidbody.velocity = moveVector;
    }

    private Vector2 MakeMoveVector(Direction direction, float speed)
    {
        if (direction == Direction.Left)
        {
            return new Vector2(-speed, 0);
        }
        else if (direction == Direction.Right)
        {
            return new Vector2(speed, 0);
        }

        return Vector2.zero;
    }

    public void Jump(Transform groundChecker, float radiusCircleChecking, LayerMask Ground, float jumpForce, Rigidbody2D actorRigidbody)
    {
        if(CheckGround(groundChecker, radiusCircleChecking, Ground))
            actorRigidbody.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
    }

    private bool CheckGround(Transform groundChecker, float radiusCircleChecking, LayerMask Ground)
    {
        bool isGrounded = Physics2D.OverlapCircle(groundChecker.position, radiusCircleChecking, Ground);
        return isGrounded;
    }
}
