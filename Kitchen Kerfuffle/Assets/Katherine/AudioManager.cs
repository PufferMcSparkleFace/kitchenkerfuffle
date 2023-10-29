using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AudioManager : MonoBehaviour
{
    [Header("--------------- Audio Source ---------------")]
    [SerializeField] AudioSource musicSource;
    [SerializeField] AudioSource SFXSource;

    [Header("--------------- BG Audio Clips ---------------")]
    public AudioClip BGMusic;

    [Header("--------------- Triangle SFX Clips ---------------")]
    public AudioClip TrideathSFX;
    public AudioClip TrijumpSFX;
    public AudioClip TrinormalShotSFX;
    public AudioClip TrispecialShotSFX;

    [Header("--------------- Circle SFX Clips ---------------")]
    public AudioClip CirdeathSFX;
    public AudioClip CirjumpSFX;
    public AudioClip CirnormalShotSFX;
    public AudioClip CirspecialShotSFX;

    private void Start()
    {
        musicSource.clip = BGMusic;
        musicSource.Play();
    }

    public void PlaySFX(AudioClip clip)
    {
        SFXSource.PlayOneShot(clip);
    }


    //old audio manager
    /*public Sound[] sounds;

    public static AudioManager instance;


    void Awake() //initialize the class method is in - forgot what this mean tbh
    {
        //for music to continue to play in the next scene
        if (instance == null)
            instance = this;
        else
        {
            Destroy(gameObject);
            return;
        }

        DontDestroyOnLoad(gameObject);


        //changing music pitch n volume. can adjust in gameobject inspector
        foreach (Sound s in sounds)
        {
            //"s" is for sound...i think lol
            s.source = gameObject.AddComponent<AudioSource>();
            s.source.clip = s.clip;

            s.source.volume = s.volume;
            s.source.pitch = s.pitch;
            s.source.loop = s.loop;
        }
    }

    private void Update()
    {
        //stop playing menu music when open to Gameplay scene
        if (SceneManager.GetActiveScene().name == "Gameplay")
        {
            Destroy(gameObject);
        }
    }

    private void Start()
    {
        //what will play in game object
        Play("MenuMusic");

    }

    // if gameobject name is different will give warning (error code thingy)
    public void Play(string name)
    {
        Sound s = Array.Find(sounds, sound => sound.name == name);
        if (s == null)
        {
            Debug.LogWarning("Sound: " + name + "not found!");
            return;
        }
        s.source.Play();

    }

    //music wont play if found wrong name in game object...i think
    public void StopPlaying(string sound)
    {
        Sound s = Array.Find(sounds, item => item.name == sound);
        if (s == null)
        {
            Debug.LogWarning("Sound: " + name + " not found!");
            return;
        }

        s.source.volume = s.volume * (1f + UnityEngine.Random.Range(-s.volume / 2f, s.volume / 2f));
        s.source.pitch = s.pitch * (1f + UnityEngine.Random.Range(-s.pitch / 2f, s.pitch / 2f));

        s.source.Stop();
    } */


}

