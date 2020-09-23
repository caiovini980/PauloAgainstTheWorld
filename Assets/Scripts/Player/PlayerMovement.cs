using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private float _speed = 5f;
    private SpriteRenderer _sprite;

    private void Awake()
    {
        _sprite = GetComponent<SpriteRenderer>();
    }

    // Start is called before the first frame update
    void Start()
    {
        if (!_sprite)
            return;
    }

    // Update is called once per frame
    void Update()
    {
        CalculateMovement();
    }

    void CalculateMovement()
    {
        float movementX = Input.GetAxis("Horizontal");
        float movementY = Input.GetAxis("Vertical");

        transform.Translate(new Vector3(movementX, movementY, 0) * _speed * Time.deltaTime);

        transform.position = new Vector3(Mathf.Clamp(transform.position.x, -8.5f, 8.5f), Mathf.Clamp(transform.position.y, -4.7f, 1.9f), 0);

        if (movementX < 0)
        {
            _sprite.flipX = false;
        }
        else if (movementX > 0)
        {
            _sprite.flipX = true;
        }
        else
        {
            _sprite.flipX = _sprite.flipX;
        }
    }

}
