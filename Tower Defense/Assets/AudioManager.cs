using UnityEngine;

public class AudioManager : MonoBehaviour
{
    [Header("Audio Source")]
    [SerializeField] AudioSource musicSource;


    public AudioClip Background;
    private void Start(){
        musicSource.clip = Background;
        musicSource.Play();
    }
}
