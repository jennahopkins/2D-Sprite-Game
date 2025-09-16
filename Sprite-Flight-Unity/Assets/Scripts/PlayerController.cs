using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UIElements;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    // Object references
    public GameObject boosterFlame1;
    public GameObject boosterFlame2;
    public GameObject explosionEffect;
    public GameObject Borders;
    private Label scoreText;
    private Label highScoreText;
    private Button restartButton;
    public UIDocument uiDocument;
    Rigidbody2D rb;

    // Movement and scoring variables
    public float thrustForce = 4f;
    public float maxSpeed = 5f;
    private float elapsedTime = 0f;
    private float score = 0f;
    public float scoreMultiplier = 10f;
    private float highScore = 0f;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // Initialize UI elements
        scoreText = uiDocument.rootVisualElement.Q<Label>("ScoreLabel");
        highScore = PlayerPrefs.GetFloat("highScore", 0);
        highScoreText = uiDocument.rootVisualElement.Q<Label>("highScoreLabel");
        highScoreText.text = "High Score: " + highScore;

        restartButton = uiDocument.rootVisualElement.Q<Button>("RestartButton");
        restartButton.style.display = DisplayStyle.None;
        restartButton.clicked += ReloadScene;

        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        UpdateScore();
        MovePlayer();
        BoosterFlame();
    }

    // calculate score based on time survived and display it
    void UpdateScore()
    {
        elapsedTime += Time.deltaTime;
        score = Mathf.FloorToInt(elapsedTime * scoreMultiplier);
        scoreText.text = "Score: " + score;
        if (score > highScore)
        {
            highScoreText.text = "High Score: " + score;
        }
    }

    // moves player on the screen
    void MovePlayer()
    {
        if (Mouse.current.leftButton.isPressed)
        {
            // Calculate mouse direction
            Vector3 mousePos = Camera.main.ScreenToWorldPoint(Mouse.current.position.value);
            Vector2 direction = (mousePos - transform.position).normalized;

            // Move player in direction of mouse
            transform.up = direction;
            rb.AddForce(direction * thrustForce);

            // Limit max speed if mouse is held down
            if (rb.linearVelocity.magnitude > maxSpeed)
            {
                rb.linearVelocity = rb.linearVelocity.normalized * maxSpeed;
            }
        }
    }

    // Toggle booster flame visibility based on mouse button state
    void BoosterFlame()
    {
        if (Mouse.current.leftButton.wasPressedThisFrame)
        {
            boosterFlame1.SetActive(true);
            boosterFlame2.SetActive(true);
        }
        else if (Mouse.current.leftButton.wasReleasedThisFrame)
        {
            boosterFlame1.SetActive(false);
            boosterFlame2.SetActive(false);
        }
    }

    // Destroy the player on collision with an obstacle
    void OnCollisionEnter2D(Collision2D collision)
    {
        // Show explosion effect
        Instantiate(explosionEffect, transform.position, transform.rotation);

        // Update high score
        if (score > highScore)
        {
            highScore = score;
            PlayerPrefs.SetFloat("highScore", highScore);
        }

        // Show restart button and disable borders
        restartButton.style.display = DisplayStyle.Flex;
        Borders.SetActive(false);
        Destroy(gameObject);
    }

    // Reload the current scene once restart button is clicked
    void ReloadScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
