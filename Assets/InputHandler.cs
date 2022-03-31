using System;
using UnityEngine;

public class InputHandler : MonoBehaviour
{
    [SerializeField] private MovableActor _actor;

    private Mover _mover;

    private void Start()
    {
        _mover = new Mover();
    }

    private void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.D))
        {
            _mover.Move(Direction.Right, _actor.Speed, _actor.RigidBody);
        }
        else if (Input.GetKey(KeyCode.A))
        {
            _mover.Move(Direction.Left, _actor.Speed, _actor.RigidBody);
        }
    }
}