using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class MovableActor : MonoBehaviour
{
    [SerializeField] private LayerMask _checkedGround;
    [SerializeField] private float _speed;
    [SerializeField] private float _jumpForce;
    [SerializeField] private float _radiusCircleCheckingGround; // Радиус окружности, проверяющий столкновение с землей

    public LayerMask CheckedGround => _checkedGround;
    public Transform GroundChecker => GetComponentInChildren<Transform>();
    public float RadiusCircleCheckingGround => _radiusCircleCheckingGround;
    public float Speed => _speed;
    public float JumpForce => _jumpForce;
    public Rigidbody2D RigidBody => GetComponent<Rigidbody2D>();
}