using UnityEngine;

public class Increaser : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private Vector3 _offsetIncrease;

    private void Update()
    {
        Increase();
    }

    private void Increase()
    {
        transform.localScale += _speed * Time.deltaTime * _offsetIncrease;
    }
}
