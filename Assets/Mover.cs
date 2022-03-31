using UnityEngine;

public enum Direction
{
    Left,
    Right
}

public class Mover
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
}
