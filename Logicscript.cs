using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using  UnityEngine.SceneManagement;
public class Logicscript : MonoBehaviour
{
    public int playerScore;
    public Text scoreText;
    public GameObject gameOverScreen;
    
 
[ContextMenu("Increase Score")]
    public void addScore()
    {
       playerScore = playerScore + 1;
       scoreText.text = playerScore.ToString();
      
    }

    public void restartGame ()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);

    }
      public void gameover()
      {
        gameOverScreen.SetActive(true);
      }

}
