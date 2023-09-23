using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehavior2 : MonoBehaviour
{

    
    public float timeStop = 5;
    private float TimeStopCounter = 0;
    public Animator myanimator;

    // Enemy Movement
    public float moveSpeed = 100f;
    private Rigidbody2D myBody;

    // Enemy Attack
    public int damage = 2;
    private float attackDelay = 5;
    private float passedTime = 0;
    
    //Enemy Health
    public int maxHealth = 5;
    public int currentHealth;


    void Start()
    {
        currentHealth = maxHealth;
        
    }

    void Awake()
    {
        myBody = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        myBody.velocity = new Vector2(moveSpeed, myBody.velocity.y);

        //Enemy Stop
        if(TimeStopCounter < timeStop){
            TimeStopCounter += Time.deltaTime;
            myanimator.SetBool("isMoving",true);
        }
        if(TimeStopCounter >= timeStop){
            moveSpeed = 0;
            myanimator.SetBool("isMoving",false);

            //Enemy Attack
            if(passedTime >= attackDelay){
                passedTime = 0;
                myanimator.SetTrigger("attack");
                FindObjectOfType<PlayerHealth>().takePlayerDamage(damage);
            }
            if(passedTime < attackDelay){
                passedTime += Time.deltaTime;
            }
        }



    }

    //Enemy Health
    public void takeDamage(int amount){
        //hurt animation
        currentHealth -= amount;
        if(currentHealth <= 0){
            //death animation
            Destroy(gameObject);
        }

    }
    public void OnMouseDown(){
        takeDamage(damage);
    }
}
