using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Civilian : MonoBehaviour
{
    public int CivilianHealth = 1;
    private int damage = 1;
    private float timeStop = 20;
    private float passedTime = 0;
    public float moveSpeed = 0;
    bool isDead = false;
    private Rigidbody2D myBody;
    public Animator myanimator;
    public AudioSource audioSource;


    // Start is called before the first frame update
    void Start()
    {
        timeStop = 15;
        audioSource = GetComponent<AudioSource>();
    }

    void Awake()
    {
        myBody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {   
        myBody.velocity = new Vector2(moveSpeed, myBody.velocity.y);
        if(passedTime <= timeStop) {
            passedTime += Time.deltaTime;
        }
        else{
            Destroy(gameObject);
        }
         if (isDead)
        {
            // Do something after waiting for 1 second
            moveSpeed = 0;
            StartCoroutine(WaitForDeath());
            
        }
    }


    public void takeDamage(int amount){
        //hurt animation
        CivilianHealth -= amount;
        audioSource.Play();
        FindObjectOfType<PlayerHealth>().takePlayerDamage(damage);
        if(CivilianHealth <= 0){
            PlayerScript.AddScore(-10);
            //death animation
            isDead = true;
        }

    }
    public void OnMouseDown(){
        takeDamage(damage);
    }
     private IEnumerator WaitForDeath()
    {
        yield return new WaitForSeconds(0.4f);
        Destroy(gameObject);
        
    }
}
