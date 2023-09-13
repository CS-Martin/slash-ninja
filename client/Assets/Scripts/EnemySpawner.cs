using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{

    [SerializeField]
    private GameObject[] enemyReference;
    private GameObject spawnedEnemy;

    [SerializeField]
    private Transform UpperLeft, UpperRight, LowerLeft, LowerRight, MiddleLeft,MiddleRight;

    private int randomIndex;
    private int randomSide;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnMonsters());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator SpawnMonsters()
{

    while (true)
    {

        yield return new WaitForSeconds(Random.Range(1, 2));

        randomIndex = Random.Range(0, enemyReference.Length);
        randomSide = Random.Range(0, 6);

        spawnedEnemy = Instantiate(enemyReference[randomIndex]);

        //Civilian
        if(randomIndex == 0) {
            // upper left 
            if (randomSide == 0)
            {
                spawnedEnemy.transform.position = UpperLeft.position;
                spawnedEnemy.GetComponent<Civilian>().moveSpeed = 140;                              
            }
            // upper right 
            else if (randomSide == 1)
            {
                spawnedEnemy.transform.position = UpperRight.position;
                spawnedEnemy.GetComponent<Civilian>().moveSpeed = -140;
                spawnedEnemy.transform.localScale = new Vector3(50, 50, 1);
            }
            // lower left 
            else if (randomSide == 2)
            {
                spawnedEnemy.transform.position = LowerLeft.position;
                spawnedEnemy.GetComponent<Civilian>().moveSpeed = 140; 
            }
            // middle right 
            else if (randomSide == 3)
            {
                spawnedEnemy.transform.position = MiddleRight.position;
                spawnedEnemy.GetComponent<Civilian>().moveSpeed = -140;
                spawnedEnemy.transform.localScale = new Vector3(50, 50, 1);
            }
            // middle left 
            else if (randomSide == 4)
            {
                spawnedEnemy.transform.position = MiddleLeft.position;
                spawnedEnemy.GetComponent<Civilian>().moveSpeed = 140;               
                
            }
            // lower right
            else
            {
                spawnedEnemy.transform.position = LowerRight.position;
                spawnedEnemy.GetComponent<Civilian>().moveSpeed = -140;                
                spawnedEnemy.transform.localScale = new Vector3(50, 50, 1);
            }
        }
        //Enemy Spawn
        else{

                // upper left 
            if (randomSide == 0)
            {
                spawnedEnemy.transform.position = UpperLeft.position;
                spawnedEnemy.GetComponent<EnemyBehavior>().moveSpeed = 140;
                spawnedEnemy.GetComponent<EnemyBehavior>().timeStop = Random.Range(4,5);
                
            }
            // upper right 
            else if (randomSide == 1)
            {
                spawnedEnemy.transform.position = UpperRight.position;
                spawnedEnemy.GetComponent<EnemyBehavior>().moveSpeed = -140;
                spawnedEnemy.GetComponent<EnemyBehavior>().timeStop = Random.Range(4,5);
                spawnedEnemy.transform.localScale = new Vector3(50, 50, 1);
            }
            // lower left 
            else if (randomSide == 2)
            {
                spawnedEnemy.transform.position = LowerLeft.position;
                spawnedEnemy.GetComponent<EnemyBehavior>().moveSpeed = 140;
                spawnedEnemy.GetComponent<EnemyBehavior>().timeStop = Random.Range(4,5);
                
            }
            // middle right 
            else if (randomSide == 3)
            {
                spawnedEnemy.transform.position = MiddleRight.position;
                spawnedEnemy.GetComponent<EnemyBehavior>().moveSpeed = -140;
                spawnedEnemy.GetComponent<EnemyBehavior>().timeStop = Random.Range(4,5);
                spawnedEnemy.transform.localScale = new Vector3(50, 50, 1);
            }
            // middle left 
            else if (randomSide == 4)
            {
                spawnedEnemy.transform.position = MiddleLeft.position;
                spawnedEnemy.GetComponent<EnemyBehavior>().moveSpeed = 140;
                spawnedEnemy.GetComponent<EnemyBehavior>().timeStop = Random.Range(4,5);
                
            }
            // lower right
            else
            {
                spawnedEnemy.transform.position = LowerRight.position;
                spawnedEnemy.GetComponent<EnemyBehavior>().moveSpeed = -140;
                spawnedEnemy.GetComponent<EnemyBehavior>().timeStop = Random.Range(4,5);
                spawnedEnemy.transform.localScale = new Vector3(50, 50, 1);
            }
        }

        
    } // while loop

}
}
