using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour
{
    [HeaderAttribute("Movement Variables in Y")]
    public float speedY;
    private Rigidbody2D _compRigidbody2D;
    void Awake()
    {
        _compRigidbody2D = GetComponent<Rigidbody2D>();
    }
    void OnTriggerEnter2D(Collider2D collider)
    {
       if (collider.CompareTag("Wall")  || collider.CompareTag("Enemy"))
       {
            Destroy(this.gameObject);
       }
    }
    void FixedUpdate()
    {
        _compRigidbody2D.velocity = new Vector2(0, speedY);
    }
}
