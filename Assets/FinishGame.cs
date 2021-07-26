using UnityEngine;
using UnityEngine.SceneManagement;



public class FinishGame : MonoBehaviour{

    private void OnCollisionEnter2D(Collision2D collision){
        SceneManager.LoadScene("Endgame");
    }

}