using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Result : MonoBehaviour
{
    [SerializeField] private Text _resultText;
    void Start()
    {
        _resultText.text = ($"Вы ответили правильно на {AnswerSystem.trueAnswers} из 20.");
    }
    public void ReturnToMenu()
    {
        SceneManager.LoadScene("Select");
    }
}
