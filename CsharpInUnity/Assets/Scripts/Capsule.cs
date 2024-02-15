using UnityEngine;

public class Capsule : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private Vector3 _offset;

    void Update()
    {
        Increase();
    }

    private void Increase()
    {
        transform.localScale += _offset * _speed * Time.deltaTime;
    }
}
