using UnityEngine;
using System.Collections;

public class TestCharacterController : MonoBehaviour
{
    [SerializeField] private Rigidbody _rb;
    [SerializeField] private Transform _t;

    private float _moveSpeed = 10f;

    private void Update()
    {
        _rb.MovePosition(_t.position + new Vector3(Input.GetAxis("Horizontal"), 0f, Input.GetAxis("Vertical")) * _moveSpeed * Time.deltaTime);
    }
}
