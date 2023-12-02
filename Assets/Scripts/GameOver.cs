using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public static GameOver instance { get; private set; }
    public bool gameOver = false;
    public AudioClip winSound;
    public AudioClip loseSound;
    AudioSource audioSource;

    public TMP_Text gameOverText;
    void Awake()
    {
        instance = this;
    }
    void Start()
    {
        gameOverText.text = "";
        audioSource = GetComponent<AudioSource>();
    }
    

    // Update is called once per frame
    void Update()
    {
        if (gameOver == true)
        {
            if (Input.GetKey(KeyCode.R))
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex); // this loads the currently active scene
            }
        }
    }
    public void PlaySound(AudioClip clip)
    {
        audioSource.PlayOneShot(clip);
    }
    public void winGame()
    {
        Debug.Log("Win Game");
        TimeTrial.instance.stopTimer();
        PlaySound(winSound);
        gameOverText.text = "You win! Game created by Group 23. Press R to restart";
        gameOver = true;
        
    }
    public void loseGame()
    {
        Debug.Log("Lose Game");
        TimeTrial.instance.stopTimer();
        PlaySound(loseSound);
        gameOverText.text = "You lose! Game created by Group 23. Press R to restart";
        gameOver = true;
        
    }
}
