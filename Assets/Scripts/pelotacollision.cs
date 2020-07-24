using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 

public class pelotacollision : MonoBehaviour
{
    public Text Scoretext;
    public int score;
    public int mutiplicador;
    public int Highscore;
    public Text Highscoretext;
    public int pelotapoint = 10;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Aro"))
        {
            Debug.Log("le pegue al aro");
            AddScore();
        }

    }
    void AddScore()
    {
        score += pelotapoint * mutiplicador;
        mutiplicador++;
        Scoretext.text = score.ToString();
        Highscore = PlayerPrefs.GetInt("highscore,0");
        Highscoretext.text = "HighScore" + Highscore;
        if (score >= Highscore)
        {
            Highscoretext.text = "highscore" + score;
        }
        
    } 
   
}
