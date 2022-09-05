using UnityEngine;

public class SoundSystem : MonoBehaviour
{
    AudioSource audioSource;
    [SerializeField] AudioClip [ ] clip;

    public static SoundSystem instance;

    private void Awake()
    {
        // 내가 찾는 오브젝트의 타입이 SoundSystem 이라면
        // var 자료형 추론 (어떤 타입이든 다 저장이 되는 자료형입니다.)
        var soundObject = FindObjectsOfType<SoundSystem>();

        // soundObject의 갯수가 한 개라면
        if(soundObject.Length > 1)
        {

            // 자기 자신을 파괴해서 오직 하나의 SoundSystem 오브젝트만 남길 수 있도록 합니다.
            Destroy(gameObject);
        }
    }

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
