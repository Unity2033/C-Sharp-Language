using UnityEngine;

public class SoundSystem : MonoBehaviour
{
    AudioSource audioSource;
    [SerializeField] AudioClip [ ] clip;

    public static SoundSystem instance;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }

    }

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    public void Sound(int number)
    {
        audioSource.PlayOneShot(clip[number]);
    }
}
