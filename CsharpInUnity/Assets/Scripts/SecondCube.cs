using UnityEngine;

public class SecondCube : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private Vector3 _offsetMove;
    [SerializeField] private Vector3 _offsetIncrease;

    void Update()
    {
        Move();
        Rotate();
        Increase();
    }

    private void Move()
    {
        transform.Translate(_offsetMove * _speed * Time.deltaTime);
    }

    private void Rotate()
    {
        //test Commit for GitHub
        transform.RotateAround(transform.position, transform.up, 0.01f);
    }

    private void Increase()
    {
        transform.localScale += _offsetIncrease * _speed * Time.deltaTime;
    }
}
