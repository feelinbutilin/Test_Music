using System.Collections.Generic;
using UnityEngine;

public class TrackNameBase : MonoBehaviour
{
    [SerializeField] private List<string> _musicList;
    public static List<string> MusicList;
    private void Awake()
    {
        MusicList = _musicList;
    }
}
