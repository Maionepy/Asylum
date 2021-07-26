using UnityEngine;
using UnityEngine.SceneManagement;



public class Respawn : MonoBehaviour{

    private void OnCollisionEnter2D(Collision2D collision){
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

}