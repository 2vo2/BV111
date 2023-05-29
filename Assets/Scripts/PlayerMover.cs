using UnityEngine;

public class PlayerMover : MonoBehaviour
{
    [SerializeField] private Rigidbody _rigidbody;
    [SerializeField] private float _speed;
    
    private void Update()
    {
        var horizontal = Input.GetAxis("Horizontal");
        var vertical = Input.GetAxis("Vertical");

        var horizonatlSpeed = horizontal * _speed * Time.deltaTime;
        var verticalSpeed = vertical * _speed * Time.deltaTime;
        
        _rigidbody.AddForce(horizonatlSpeed, 0f, verticalSpeed, ForceMode.Impulse);
    }
}
