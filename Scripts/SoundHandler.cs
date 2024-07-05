using System.Collections;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class SoundHandler : MonoBehaviour
{
    [SerializeField] private float _fadeSpeed;

    private AudioSource _audioSourse;
    private Coroutine _coroutine;

    public void Initialize()
    {
        _audioSourse = GetComponent<AudioSource>();
    }

    public void IncreaseVolume()
    {
        CoroutineStart(1);
    }

    public void DecreaseVolume()
    {
        CoroutineStart(0);
    }

    private IEnumerator ChangeVolume(float current, float target)
    {
        float currentTime = 0f;

        while (currentTime < _fadeSpeed)
        {
            currentTime += Time.deltaTime;
            _audioSourse.volume = Mathf.Lerp(current, target, currentTime / _fadeSpeed);

            yield return null;
        }

        _audioSourse.volume = target;
    }

    private void CoroutineStart(float targer)
    {
        _coroutine = StartCoroutine(ChangeVolume(_audioSourse.volume, targer));
    }
}