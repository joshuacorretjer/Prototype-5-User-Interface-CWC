using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{

    public List<GameObject> targets;

    public float spawnRate = 1.0f;

    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI gameOverText;

    public Button restartButton;

    public GameObject titleScreen;

    public bool isGameActive;

    private int score;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator SpawnTarget()
    {
        while (isGameActive)
        {
            yield return new WaitForSeconds(spawnRate);
            int index = Random.Range(0, targets.Count);
            Instantiate(targets[index]);
        }
    }

    public void StartGame(int difficulty)
    {
        spawnRate /= difficulty;
        // dividing spawnrate by a whole number makes it that times faster, for example: 1/3 = 3 times faster
        titleScreen.gameObject.SetActive(false);
        scoreText.gameObject.SetActive(true);
        isGameActive = true;
        StartCoroutine(SpawnTarget());
        UpdateScore(0);
    }

    public void UpdateScore(int scoreToAdd)
    {
        score += scoreToAdd;
        if (score <= 0)
        {
            scoreText.text = "Score: " + 0;
        }
        else
        {
            scoreText.text = "Score: " + score;
        }

        /*
        score += scoreToAdd;
        scoreText.text = "Score: " + score;
        */

        /*
         * or u can use this:
         * scoreText.text += score;
         * this concatenates whats already there with the score, and the other one changes the text to 'Score: ' and concatenates the score
        */
    }

    public void GameOver()
    {
        isGameActive = false;
        gameOverText.gameObject.SetActive(true);
        restartButton.gameObject.SetActive(true);
        // Instead of writing this line of code, you can parent it underneath the Game Over Test Object, so it will activate and deactivate at the same time as Game Over
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        //you can also use: SceneManager.LoadScene(String Name of Scene);
    }
}
