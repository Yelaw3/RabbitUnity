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

    void Start() //On récupère et active le Rigidbody, Animator et AudioSource au lancement du jeu
    {
        playerRb = GetComponent<Rigidbody>();
        playerAnim = GetComponent<Animator>();
        playerAudio = GetComponent<AudioSource>();
    }

    private void OnCollisionEnter(Collision collision) //Quand le joueur est en collision avec le sol, la variable isOnGround est vraie
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isOnGround = true;
        }
    }

    void Update() 
    {
        horizontalInput = Input.GetAxis("Horizontal"); //On assigne les touches pour les déplacements sur l'axe horizontal
        forwardInput = Input.GetAxis("Vertical"); //On assigne les touches pour les déplacements sur l'axe vertical
        transform.Translate(Vector3.back * speed * forwardInput * Time.deltaTime);
        transform.Rotate(transform.up, turnSpeed * horizontalInput * Time.deltaTime);

        if (Input.GetKeyDown(KeyCode.Space) && isOnGround) //Si on appuie sur la barre espace et que la variable isOnGround est vraie : on active l'animation de saut, on saute, la variable isOnground est fausse et on joue le son de saut
        {
            playerAnim.SetTrigger("jump_trigger");
            playerRb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            isOnGround = false;
            playerAudio.PlayOneShot(jumpSound, 0.05f);
        }
        else //Sinon, le saut ne peut pas être activé
        {
            playerAnim.SetBool("jump_boolean", false);
        }
    }
}
