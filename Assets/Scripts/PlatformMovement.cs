using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformMovement : MonoBehaviour
{
    public KeyCode rightKey, leftKey;
    public float speed;

    private Rigidbody2D _rb;
    private SpriteRenderer _spriteRenderer;
    private Vector2 _dir;

    private Animator _animator;
   
    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
        _spriteRenderer = GetComponent<SpriteRenderer>();
        _animator = GetComponent<Animator>();
    }

    void Update()
    {
        if(Input.GetKey(rightKey))
        {
            _animator.SetBool("caminar", true);
            _dir = new Vector2(1, 0);
            _spriteRenderer.flipX = false;

        }
        else if(Input.GetKey(leftKey)) 
        {
            _animator.SetBool("caminar", true);
            _dir = new Vector2(-1, 0);
            _spriteRenderer.flipX = true;

        }
        else
        {
            _animator.SetBool("caminar", false);
            _dir = Vector2.zero;
        }
    }

    private void FixedUpdate()
    {
        _rb.velocity = _dir * speed;
    }
}
