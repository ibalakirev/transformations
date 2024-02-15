using UnityEngine;

public class Cube : MonoBehaviour
{
    [SerializeField] private float _speed;

    void Update()
    {
        Rotate();
    }

    private void Rotate()
    {
        transform.RotateAround(transform.position, transform.up, _speed * Time.deltaTime);
    }
}
