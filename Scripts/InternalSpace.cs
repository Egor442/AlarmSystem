using UnityEngine;

public class InternalSpace : MonoBehaviour
{
    [SerializeField] private SoundHandler _soundHandler;

    private void OnTriggerEnter(Collider other)
    {
        if (other.TryGetComponent(out �rook crook))
        {
            _soundHandler.IncreaseVolume();
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.TryGetComponent(out �rook crook))
        {
            _soundHandler.DecreaseVolume();
        }
    }
}