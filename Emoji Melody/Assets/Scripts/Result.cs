using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Result : MonoBehaviour
{
    [SerializeField] private Text _resultText;
    void Start()
    {
        _resultText.text = ($"�� �������� ��������� �� {AnswerSystem.trueAnswers} �� 20.");
    }
    public void ReturnToMenu()
    {
        SceneManager.LoadScene("Select");
    }
}
