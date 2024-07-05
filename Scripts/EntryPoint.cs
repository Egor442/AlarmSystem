using UnityEngine;

public class EntryPoint : MonoBehaviour
{
    [SerializeField] private SoundHandler _soundHandler;

    private void Awake()
    {
        _soundHandler.Initialize();
    }
}