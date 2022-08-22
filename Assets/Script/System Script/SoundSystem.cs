using UnityEngine;

public class SoundSystem : MonoBehaviour
{
    AudioSource audioSource;
    [SerializeField] AudioClip [ ] clip;

    public static SoundSystem instance;

    void Start()
    {
        if(instance == null)
        {
            instance = this;
        }

        audioSource = GetComponent<AudioSource>();

        DontDestroyOnLoad(gameObject);
    }

    public void Sound(int number)
    {
        audioSource.PlayOneShot(clip[number]);
    }
}
