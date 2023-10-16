using UnityEngine;
using UnityEngine.SceneManagement;

public class SelectLevel : MonoBehaviour
{
    public static int currentPart;

    public void Part2018()
    {
        SceneLoader(1, 0);
    }
    public void Part2019()
    {
        SceneLoader(2, 20);
    }
    public void Part2020()
    {
        SceneLoader(3, 40);
    }
    public void Part2021()
    {
        SceneLoader(4, 60);
    }
    public void Part2022()
    {
        SceneLoader(5, 80);
    }
    public void SceneLoader(int part, int track)
    {
        currentPart = part;
        AnswerSystem.currentTrackNumber = track;
        AnswerSystem.trueAnswers = 0;
        AnswerSystem.answered = false;
        AnswerSystem.buttonTimeOut = true;
        SceneManager.LoadScene(0);
    }
    public void ReturnToStart()
    {
        SceneManager.LoadScene("Main");
    }
}
