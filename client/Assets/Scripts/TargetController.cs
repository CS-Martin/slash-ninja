using UnityEngine;

public class TargetController : MonoBehaviour
{
    public ParticleSystem explosionEffect;
    public float jumpForce = 10f;
    public float minJumpDelay = 1f;
    public float maxJumpDelay = 3f;
    private Rigidbody2D rb;
    public float speedIncreaseRate = 0.1f;
    private float currentSpeed = 1f;
    private float lastJumpTime = 0f;
    public float shootTimeWindow = 3f;
    private float lastShotTime = 0f;
    public AudioSource hitSound;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        currentSpeed = 1f;
    }

    void Update()
    {
        if (transform.position.y < -10f)
        {
            Jump();
        }
        currentSpeed += speedIncreaseRate * Time.deltaTime;

        if (Time.time - lastShotTime > shootTimeWindow)
        {
            HitPlayer();
        }
    }

    private void OnMouseDown()
    {
        Destroy(gameObject);
        Instantiate(explosionEffect, transform.position, Quaternion.identity);
        hitSound.Play();
        lastShotTime = Time.time;
    }

    private void Jump()
    {
        float jumpDelay = Random.Range(minJumpDelay, maxJumpDelay);
        lastJumpTime = Time.time;
        rb.velocity = Vector2.up * jumpForce * currentSpeed;
    }

    private void HitPlayer()
    {
        Debug.Log("Target hit player");
    }
}