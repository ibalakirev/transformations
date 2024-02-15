using UnityEngine;

public class Sphere : MonoBehaviour
{
    [SerializeField] private Vector3 _offset;
    [SerializeField] private float _speed;

    private void Update()
    {
        Move();
    }

    private void Move()
    {
        transform.Translate(_offset * _speed * Time.deltaTime);
    }
}
