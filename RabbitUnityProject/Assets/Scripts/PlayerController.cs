using System.Collections;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float turnSpeed = 15;
    private float horizontalInput;
    private float forwardInput;
    public float jumpForce = 10;
    public float speed = -4;
    public AudioClip jumpSound;
    private Rigidbody playerRb;
    private Animator playerAnim;
    private AudioSource playerAudio;
    public bool isOnGround = true;

    // Start is called before the first frame update
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
        playerAnim = GetComponent<Animator>();
        playerAudio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");
        transform.Translate(Vector3.back * speed * forwardInput * Time.deltaTime);
        transform.Rotate(transform.up, turnSpeed * horizontalInput * Time.deltaTime);

        if (Input.GetKeyDown(KeyCode.Space) && isOnGround)
        {
            playerAnim.SetTrigger("jump_trigger");
            playerRb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            isOnGround = false;
            playerAudio.PlayOneShot(jumpSound, 0.05f);
        }
        else
        {
            playerAnim.SetBool("jump_boolean", false);
        }
    }


    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isOnGround = true;
        }
    }
}
