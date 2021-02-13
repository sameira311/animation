using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private Animator _animator;
    [SerializeField] private Rigidbody2D _rigidbody2d;
    [SerializeField] private float _speed = 2f;

    private Vector2 _movement;

    // Update is called once per frame
    void Update()
    {
        _movement.x = Input.GetAxis("Horizontal");
        _movement.y = Input.GetAxis("Vertical");


        _animator.SetFloat("Horizontal", _movement.x);
        _animator.SetFloat("Vertical", _movement.y);
        _animator.SetFloat("Speed", _movement.sqrMagnitude);
    }

    private void FixedUpdate() {
        _rigidbody2d.velocity = new Vector2(_movement.x * _speed * Time.fixedDeltaTime, _movement.y * _speed * Time.deltaTime);
    }
}
