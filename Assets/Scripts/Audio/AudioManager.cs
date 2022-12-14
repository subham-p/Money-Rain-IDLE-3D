using UnityEngine.Audio;
using System;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    
    public Sound[] sounds;

    private static AudioManager _instance;

     public static AudioManager Instance 
    { 
        get { return _instance; } 
    } 

    void Awake()
    {
         if (_instance != null && _instance != this) 
        { 
            Destroy(this.gameObject);
            return;
        }

        _instance = this;
        DontDestroyOnLoad(this.gameObject);

        foreach(Sound s in sounds)
        {
            s.source=gameObject.AddComponent<AudioSource>();
            s.source.clip = s.clip;
            s.source.volume = s.volume;
            s.source.pitch = s.pitch;
            s.source.loop =s.loop;
        }
    }


    public void Play(String name)
    {

            Sound s=Array.Find(sounds, sound=> sound.name == name);
            if(s==null)
            {
                Debug.LogWarning("Sound: "+ name + " not found!");
                return;
            }
            s.source.Play();
    }

    public void Stop(String name)
    {
            Sound s=Array.Find(sounds, sound=> sound.name == name);
            if(s==null)
            {
                Debug.LogWarning("Sound: "+ name + " not found!");
                return;
            }
            s.source.Stop();
    }


    
}