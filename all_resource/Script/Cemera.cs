using UnityEngine;

public class Cemera : MonoBehaviour
{
    [SerializeField] private Transform _target;
    private Vector3 _targetPosition;
    private void Start()
    {
        transform.Rotate(10f,0,0);
    }

    private void Update()
    {
        if(_target != null) {
            _targetPosition.x = _target.position.x;
            _targetPosition.y = _target.position.y + 1;
            _targetPosition.z = _target.position.z - 5;
            transform.position = _targetPosition;
        }
       
    }
}
