using UnityEngine;

public class Rotator : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private Vector3 _axisRotation;

    private void Update()
    {
        Rotate();
    }

    private void Rotate()
    {
        transform.RotateAround(transform.position, _axisRotation, _speed * Time.deltaTime);
    }
}
