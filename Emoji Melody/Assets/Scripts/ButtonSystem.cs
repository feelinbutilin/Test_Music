using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonSystem : MonoBehaviour
{
    [SerializeField] private List<Button> _buttons;
    private List<string> _tempMusicList;
    [SerializeField] private List<Sprite> _emojis;
    [SerializeField] private GameObject _questionImage;
    public static Button TrueButton;

    private void Awake()
    {
        _questionImage.GetComponent<Image>().sprite = _emojis[AnswerSystem.currentTrackNumber];
    }

    private void Start()
    {
        RandomiseButtons();
        SetTrackNames();
    }

    System.Random rand = new System.Random();
    private void RandomiseButtons()
    {
        for (int i = _buttons.Count - 1; i >= 1; i--)
        {
            int j = rand.Next(i + 1);
            var temp = _buttons[j];
            _buttons[j] = _buttons[i];
            _buttons[i] = temp;
        }
    }
    private void SetTrackNames()
    {
        _buttons[0].GetComponentInChildren<Text>().text = TrackNameBase.MusicList[AnswerSystem.currentTrackNumber];
        _buttons[0].GetComponent<AnswerSystem>().isTrueAnswer = true;
        TrueButton = _buttons[0];
        _tempMusicList = CloneList(TrackNameBase.MusicList);
        _tempMusicList.Remove(TrackNameBase.MusicList[AnswerSystem.currentTrackNumber]);

        for (int i = _tempMusicList.Count - 1; i >= 1; i--)
        {
            int j = rand.Next(i + 1);
            var temp = _tempMusicList[j];
            _tempMusicList[j] = _tempMusicList[i];
            _tempMusicList[i] = temp;
        }

        for (int i = 1; i < _buttons.Count; i++)
        {
            _buttons[i].GetComponentInChildren<Text>().text = _tempMusicList[i];
        }
    }

    public List<T> CloneList<T>(List<T> originalList)
    {
        List<T> clonedList = new List<T>(originalList.Count);

        foreach (T item in originalList)
        {
            clonedList.Add(item);
        }
        return clonedList;
    }
}
