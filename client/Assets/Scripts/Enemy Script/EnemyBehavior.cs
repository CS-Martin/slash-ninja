using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehavior : MonoBehaviour
{
    public GameObject attackParticlePrefab;
    public Animator myanimator;
    private Rigidbody2D myBody;
    public AudioSource audioSource;
    
    public float timeStop = 5;
    private float TimeStopCounter = 0;

    private bool isDead;

    // Enemy Movement
    public float moveSpeed = 100f;
    

    // Enemy Attack
    public int damage = 1;
    public float attackDelay = 2;
    private float passedTime = 0;
    
    //Enemy Health
    public int maxHealth = 1;
    public int currentHealth;


    void Start()
    {
        currentHealth = maxHealth;
        
        isDead = false;
        Vector2 objectPosition = transform.position;
        audioSource = GetComponent<AudioSource>();

        
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
                AttackVFX();
                myanimator.SetTrigger("attack");
                FindObjectOfType<PlayerHealth>().takePlayerDamage(damage);
            }
            if(passedTime < attackDelay){
                passedTime += Time.deltaTime;
            }
        }
        if (isDead)
        {
            // Do something after waiting for 1 second
            moveSpeed = 0;
            StartCoroutine(WaitForDeath());
            
        }
        

    }

    //Enemy Health
    public void takeDamage(int amount){
        //hurt animation missing
        currentHealth -= amount;
        if(currentHealth <= 0){
            PlayerScript.AddScore(10);
            //death animation missing
            audioSource.Play();
            isDead = true;
        }

    }
    public void OnMouseDown(){
       
        takeDamage(damage);
    }


    // Code to execute after waiting for 1 second
     private IEnumerator WaitForDeath()
    {
        yield return new WaitForSeconds(0.4f);
        Destroy(gameObject);
        
    }

    void AttackVFX()
    {
            // Instantiate the attack particle effect at the spawn point
            GameObject attackParticle = Instantiate(attackParticlePrefab, transform.position, Quaternion.identity);

            // Destroy the attack particle after it finishes playing
            Destroy(attackParticle, 2f);
    }
}
