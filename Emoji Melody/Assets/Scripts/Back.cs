using UnityEngine;
using UnityEngine.SceneManagement;

public class Back : MonoBehaviour
{
    public void ReturnToMenu() 
    {
        SceneManager.LoadScene("Main");
    }

}
