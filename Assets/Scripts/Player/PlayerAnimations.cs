using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimations : MonoBehaviour
{
    private Animator _animator;

    private void Awake()
    {
        _animator = GetComponent<Animator>();
    }

    // Start is called before the first frame update
    void Start()
    {
        if (!_animator)
            return;

        _animator.SetFloat("Speed", 0f);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.D))
        {
            _animator.SetFloat("Speed", 0.5f);
        }
        else if (Input.GetKeyDown(KeyCode.J))
        {
            _animator.SetTrigger("Attack");
        }
        else
        {
            _animator.SetFloat("Speed", 0f);
        }
    }
}
