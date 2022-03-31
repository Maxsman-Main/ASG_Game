using UnityEngine;

[RequireComponent(typeof(Transform))]
public class TowerBuilder : MonoBehaviour
{
    [SerializeField] private GameObject _build;

    private Transform _transform;

    private void Start()
    {
        _transform = gameObject.GetComponent<Transform>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            BuildTower(_build, _transform.position);
        }
    }

    private void BuildTower(GameObject build, Vector3 spawnPosition)
    {
        Instantiate(build, spawnPosition, Quaternion.identity);
    }
}
