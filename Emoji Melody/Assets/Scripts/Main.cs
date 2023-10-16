using UnityEngine;
using UnityEngine.SceneManagement;

public class Main : MonoBehaviour
{
    // Start is called before the first frame update
    public void SelectLevel()
    {
        SceneManager.LoadScene("Select");
    }
    public void MoreGames()
    {
        Application.OpenURL("https://yandex.ru/games/developer?name=Duende%20Interactive");
    }
    public void AboutUs()
    {
        SceneManager.LoadScene("About");
    }
}
