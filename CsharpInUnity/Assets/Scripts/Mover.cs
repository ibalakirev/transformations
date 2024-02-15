using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] private float _speed;

    private void Update()
    {
        Move();
    }

    private void Move()
    {
        transform.Translate( _speed * Time.deltaTime * Vector3.forward);
    }
}
