using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [HeaderAttribute("Movement Variables in X")]
    public float speedX;
    public int directionX;
    [HeaderAttribute("Movement Variables in Y")]
    public float speedY;
    public int directionY;
    private SpriteRenderer _compSpriteRenderer;
    private Rigidbody2D _compRigidbody2D;
    private AudioSource _compAudioSource;
    public GameObject bulletPrefab;

    void Awake()
    {
        _compSpriteRenderer = GetComponent<SpriteRenderer>();
        _compRigidbody2D = GetComponent<Rigidbody2D>();
        _compAudioSource = GetComponent<AudioSource>();
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("d") == true)
        {
            directionX = 1;
            _compSpriteRenderer.flipX = false;
        }
        else if (Input.GetKey("a") == true)
        {
            directionX = -1;
            _compSpriteRenderer.flipX = true;
        }
        else 
        {
            directionX = 0;
        }
        if (Input.GetKey("w") == true)
        {
            directionY = 1;
        }
        else if (Input.GetKey("s") == true)
        {
            directionY = -1;
        }
        else
        {
            directionY = 0;
        }
        if(Input.GetKeyDown(KeyCode.Space) == true)
        {
            Instantiate(bulletPrefab, transform.position, transform.rotation);
            _compAudioSource.Play();
        }
    }
    void FixedUpdate()
    {
        _compRigidbody2D.velocity = new Vector2( speedX * directionX , speedY * directionY);
    }
}
