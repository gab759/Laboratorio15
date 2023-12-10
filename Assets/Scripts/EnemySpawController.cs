using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawController : MonoBehaviour
{
    public GameObject enemyPrefab;
    [HeaderAttribute("Time Spawn enemys")]
    public float generationTime = 3;
    private float rndX;
    private float rndY;
    private float  timeElapsed = 0;
    public GameManagerController gameManager;
    void Update()
    {
        timeElapsed = Time.deltaTime +  timeElapsed;
        GenerarRandom();
       if ( timeElapsed >= generationTime)
       {
           GenerarEnemigo();
            timeElapsed = 0;
       }
    }
    void GenerarEnemigo()
    {
       GameObject enemy = Instantiate(enemyPrefab, new Vector2(rndX, rndY), transform.rotation);
        enemy.GetComponent<enemyController>().SetGameManager(gameManager);
    }
    void GenerarRandom()
    {
        rndX = Random.Range(-8.46f, 8.46f);
        rndY = Random.Range(3.09f, 4.58f);
    }
}
