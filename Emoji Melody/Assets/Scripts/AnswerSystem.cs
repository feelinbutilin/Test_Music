using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using Plugins.Audio.Core;
using System.Collections;

public class AnswerSystem : MonoBehaviour
{

    [SerializeField] private AudioSource _audioSource;
    [SerializeField] private SourceAudio _sourceAudio;
    public static int trueAnswers;
    public static int currentTrackNumber;
    public static bool buttonTimeOut;
    public static bool trackIsPlaying = false;
    public static bool answered = false;
    public bool isTrueAnswer;
    private static bool coroutineStarted = false;
    private Button _trueButton;
    private Button _thisButton;
    private static float _timeLeft = 1.5f;

    private void Start()
    {
        coroutineStarted = false;
        _thisButton = GetComponent<Button>();
        _thisButton.onClick.AddListener(CheckAnswer);
    }
    private void FixedUpdate()
    {
        if (answered)
        {
            if (!_audioSource.isPlaying && !trackIsPlaying)
            {
                _sourceAudio.Play(currentTrackNumber.ToString());
                trackIsPlaying = true;
                _timeLeft = 1.5f;
            }
            else if (!_audioSource.isPlaying && trackIsPlaying && _timeLeft <= 0)
            {
                if (!coroutineStarted)
                {
                    StartCoroutine(SceneLoader());
                    coroutineStarted = true;
                }
            }
            _timeLeft -= Time.fixedDeltaTime;
        }
    }
    public void CheckAnswer()
    {
        if (buttonTimeOut)
        {
            _trueButton = ButtonSystem.TrueButton;
            if (isTrueAnswer)
            {
                buttonTimeOut = false;
                RepaintButton(true);
                ++trueAnswers;
            }
            else
            {
                buttonTimeOut = false;
                RepaintButton(false);
            }
            answered = true;
        }
    }

    private IEnumerator SceneLoader()
    {
        yield return new WaitForSeconds(1.5f);
        answered = false;
        trackIsPlaying = false;
        buttonTimeOut = true;
        currentTrackNumber += 1;
        switch (SelectLevel.currentPart)
        {
            case 1:
                if (currentTrackNumber > 0 && currentTrackNumber < 20)
                {
                    SceneManager.LoadScene(1);
                }
                else
                {
                    SceneManager.LoadScene("End");
                }
                break;
            case 2:
                if (currentTrackNumber > 20 && currentTrackNumber < 40)
                {
                    SceneManager.LoadScene(1);
                }
                else
                {
                    SceneManager.LoadScene("End");
                }
                break;
            case 3:
                if (currentTrackNumber > 40 && currentTrackNumber < 60)
                {
                    SceneManager.LoadScene(1);
                }
                else
                {
                    SceneManager.LoadScene("End");
                }
                break;
            case 4:
                if (currentTrackNumber > 60 && currentTrackNumber < 80)
                {
                    SceneManager.LoadScene(1);
                }
                else
                {
                    SceneManager.LoadScene("End");
                }
                break;
            case 5:
                if (currentTrackNumber > 80 && currentTrackNumber < 100)
                {
                    SceneManager.LoadScene(1);
                }
                else
                {
                    SceneManager.LoadScene("End");
                }
                break;
        }
    }
    public void RepaintButton(bool isTrue)
    {
        if (!isTrue)
        {
            ColorBlock cbb = _thisButton.colors;
            cbb.selectedColor = Color.red;
            cbb.normalColor = Color.red;
            cbb.disabledColor = Color.red;
            cbb.highlightedColor = Color.red;
            cbb.pressedColor = Color.red;
            _thisButton.colors = cbb;
        }
        ColorBlock cb = _trueButton.colors;
        cb.selectedColor = Color.green;
        cb.normalColor = Color.green;
        cb.disabledColor = Color.green;
        cb.highlightedColor = Color.green;
        cb.pressedColor = Color.green;
        _trueButton.colors = cb;
    }
}