using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BackgroundChanger : MonoBehaviour
{
    [SerializeField] private List<Sprite> _sprites;
    [SerializeField] private GameObject _backgroundImage;
    private void Awake()
    {
        ChangeBackground();
    }
    private void ChangeBackground()
    {
        switch (SelectLevel.currentPart)
        {
            case 1:
                _backgroundImage.GetComponent<Image>().sprite = _sprites[0]; 
                break;
            case 2:
                _backgroundImage.GetComponent<Image>().sprite = _sprites[1];
                break;
            case 3:
                _backgroundImage.GetComponent<Image>().sprite = _sprites[2];
                break;
            case 4:
                _backgroundImage.GetComponent<Image>().sprite = _sprites[3];
                break;
            case 5:
                _backgroundImage.GetComponent<Image>().sprite = _sprites[4];
                break;
        }
    }
}
