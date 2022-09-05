using UnityEngine;

public class SoundSystem : MonoBehaviour
{
    AudioSource audioSource;
    [SerializeField] AudioClip [ ] clip;

    public static SoundSystem instance;

    private void Awake()
    {
        // ���� ã�� ������Ʈ�� Ÿ���� SoundSystem �̶��
        // var �ڷ��� �߷� (� Ÿ���̵� �� ������ �Ǵ� �ڷ����Դϴ�.)
        var soundObject = FindObjectsOfType<SoundSystem>();

        // soundObject�� ������ �� �����
        if(soundObject.Length > 1)
        {

            // �ڱ� �ڽ��� �ı��ؼ� ���� �ϳ��� SoundSystem ������Ʈ�� ���� �� �ֵ��� �մϴ�.
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
