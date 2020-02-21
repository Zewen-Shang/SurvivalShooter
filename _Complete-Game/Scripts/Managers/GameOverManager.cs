using UnityEngine;
using UnityEngine.SceneManagement;

namespace CompleteProject
{
    public class GameOverManager : MonoBehaviour
    {
        public PlayerHealth playerHealth;       // Reference to the player's health.


        Animator anim;                          // Reference to the animator component.
        
        float restartTime;
        float restartDelay = 5f;
        bool isOver;
        void Awake ()
        {
            // Set up the reference.
            anim = GetComponent <Animator> ();
        }


        void Update ()
        {
            // If the player has run out of health...
            if(playerHealth.currentHealth <= 0 && !isOver)
            {
                isOver = true;
                // ... tell the animator the game is over.
                anim.SetTrigger ("GameOver");
            }
            if(isOver){
                restartTime += Time.deltaTime;
                if(restartTime >= restartDelay){
                    SceneManager.LoadScene(0);
                }
            }
        }
    }
}