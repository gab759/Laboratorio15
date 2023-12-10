 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyController : MonoBehaviour
{
    [HeaderAttribute("Movement Variables in Y")]
    public float speedY;
    private int directionEnemyY = -1;
    private Animator _compAnimator;
    private Rigidbody2D _compRigidbody2D;
    public GameManagerController gameManager;
    void Awake()
    {
        _compAnimator = GetComponent<Animator>();
        _compRigidbody2D = GetComponent<Rigidbody2D>();
    }
    void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.CompareTag("Bullet"))  
        {
            GetComponent<BoxCollider2D>().enabled = false;
            gameManager.UpdatePoints(20);
            _compAnimator.SetTrigger("IsDeath");  
            Destroy(this.gameObject, 0.8f);
        }
        else if (collider.CompareTag("Wall"))
        {
            _compAnimator.SetTrigger("IsDeath");
            Destroy(this.gameObject, 0.8f);
        }
    }
    public void SetGameManager(GameManagerController gm)
    {
        gameManager = gm;
    }
    void FixedUpdate()
    {
        _compRigidbody2D.velocity = new Vector2(0, speedY * directionEnemyY);
    }
}
