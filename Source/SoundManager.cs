using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class SoundManager : MonoBehaviour
{
    public static SoundManager instance;

    private static Dictionary<string, AudioClip> BGMaudioPairs = new Dictionary<string, AudioClip>();
    [SerializeField] AudioMixer mixer;


    public const string MASTER_KEY = "masterVolume";
    public const string BGM_KEY = "bgmVolume";
    public const string SFX_KEY = "sfxVolume";

    //player SFX
    public AudioClip sfx_jump;
    public AudioClip sfx_throw;
    public AudioClip sfx_eatSnow;
    public AudioClip sfx_eatBitSnow;
    public AudioClip sfx_land;

    //snow SFX
    public AudioClip sfx_snowZero;

    public AudioClip sfx_snowOverlap_1;

    //object SFX
    public AudioClip sfx_switch;
    public AudioClip sfx_barrier;
    public AudioClip sfx_iceCycle;
    public AudioClip sfx_fallingPlatform;
    public AudioClip sfx_jumpPad;
    public AudioClip sfx_checkPoint;
    public AudioClip sfx_collectable;
    public AudioClip sfx_goal;
    public AudioClip sfx_clearState;
    public AudioClip sfx_bulletColl;




    public AudioClip sfx_sword_1;
    public AudioClip sfx_sword_2;
    public AudioClip sfx_axe;




    public GameObject soundObject;

    public AudioSource bgmAudioSource;
    public AudioClip bgm_menu;
    public AudioClip bgm_snow;
    public AudioClip bgm_city;
    public AudioClip bgm_spirit;
    private AudioClip curBGMclip;



    void Awake()
    {
        //remove when want bgm to connect to each scene

        
        if(instance != null)
        {
            Destroy(gameObject);
            return;
        }
        else
        {
            instance = this;
            DontDestroyOnLoad(this.gameObject);
        }

        //instance = this;

        /*
        GameObject[] musicObj = GameObject.FindGameObjectsWithTag("SoundManager");

        if(musicObj.Length > 1)
        {
            Destroy(this.gameObject);
        }
        DontDestroyOnLoad(this.gameObject);
        */
        AddBGMLists();
        LoadVolume();
    }


    public void PlaySFX(string sfxName)
    { 
        switch(sfxName)
        {
            //character SFX
            case "jump":
                SoundObjectCreation(sfx_jump);
                break;
            case "throw":
                SoundObjectCreation(sfx_throw);
                break;
            case "eatSnow":
                SoundObjectCreation(sfx_eatSnow);
                break;
            case "eatBitSnow":
                SoundObjectCreation(sfx_eatBitSnow);
                break;
            case "land":
                SoundObjectCreation(sfx_land);
                break;

            //snow SFX
            case "snowZero":
                SoundObjectCreation(sfx_snowZero);
                break;
            case "snowOverlap_1":
                SoundObjectCreation(sfx_snowOverlap_1);
                break;

            //object SFX
            case "switch":
                SoundObjectCreation(sfx_switch);
                break;
            case "barrier":
                SoundObjectCreation(sfx_barrier);
                break;
            case "iceCycle":
                SoundObjectCreation(sfx_iceCycle);
                break;
            case "fallingPlatform":
                SoundObjectCreation(sfx_fallingPlatform);
                break;
            case "jumpPad":
                SoundObjectCreation(sfx_jumpPad);
                break;
            case "checkPoint":
                SoundObjectCreation(sfx_checkPoint);
                break;
            case "collectable":
                SoundObjectCreation(sfx_collectable);
                break;
            case "goal":
                SoundObjectCreation(sfx_goal);
                break;
            case "clearState":
                SoundObjectCreation(sfx_clearState);
                break;
            case "bulletColl":
                SoundObjectCreation(sfx_bulletColl);
                break;

            //Object collision
            case "sword_1":
                SoundObjectCreation(sfx_jumpPad);
                break;
            case "sword_2":
                SoundObjectCreation(sfx_jumpPad);
                break;
            case "axe":
                SoundObjectCreation(sfx_jumpPad);
                break;
            default:
                break;
        }
    }

    public void StopSFX(string sfxName)
    {
        switch (sfxName)
        {
            //character SFX
            case "jump":
                SoundObjectDelete(sfx_jump);
                break;
            case "throw":
                SoundObjectDelete(sfx_throw);
                break;
            case "eatSnow":
                SoundObjectDelete(sfx_eatSnow);
                break;
            case "land":
                SoundObjectDelete(sfx_land);
                break;

            //snow SFX
            case "snowZero":
                SoundObjectDelete(sfx_snowZero);
                break;
            case "snowOverlap_1":
                SoundObjectDelete(sfx_snowOverlap_1);
                break;

            //object SFX
            case "switch":
                SoundObjectDelete(sfx_switch);
                break;
            case "barrier":
                SoundObjectDelete(sfx_barrier);
                break;
            case "iceCycle":
                SoundObjectDelete(sfx_iceCycle);
                break;
            case "fallingPlatform":
                SoundObjectDelete(sfx_fallingPlatform);
                break;
            case "jumpPad":
                SoundObjectDelete(sfx_jumpPad);
                break;
            default:
                break;
        }
    }

    void SoundObjectCreation(AudioClip clip)
    {
        //Create SoundObject gameobject
        GameObject newObject = Instantiate(soundObject, transform);
        //Assign audioclip to its audioSource
        newObject.GetComponent<AudioSource>().clip = clip;
        //Play the audio
        newObject.GetComponent<AudioSource>().Play();
    }

    void SoundObjectDelete(AudioClip clip)
    {
        //Create SoundObject gameobject
        GameObject newObject = Instantiate(soundObject, transform);
        //Assign audioclip to its audioSource
        newObject.GetComponent<AudioSource>().clip = clip;

        //Stop the audio
        newObject.GetComponent<AudioSource>().Stop();
    }


    void LoadVolume()  //Volume saved in SettingsMenu.cs
    {
        float masterVolume = PlayerPrefs.GetFloat(MASTER_KEY, 1f);
        float bgmVolume = PlayerPrefs.GetFloat(BGM_KEY, 1f);
        float sfxVolume = PlayerPrefs.GetFloat(SFX_KEY, 1f);


        mixer.SetFloat(SettingsMenu.MIXER_MASTER, Mathf.Log10(masterVolume) * 20);
        mixer.SetFloat(SettingsMenu.MIXER_BGM, Mathf.Log10(bgmVolume) * 20);
        mixer.SetFloat(SettingsMenu.MIXER_SFX, Mathf.Log10(sfxVolume) * 20);
    }

    void AddBGMLists()
    {
        bgmAudioSource = this.gameObject.GetComponent<AudioSource>();
        BGMaudioPairs.Add("MENU", bgm_menu);
        BGMaudioPairs.Add("SNOW", bgm_snow);
        BGMaudioPairs.Add("CITY", bgm_city);
        BGMaudioPairs.Add("SPIRIT", bgm_spirit);
        curBGMclip = bgm_menu;
    }

    public void playBGM(string theme)
    {
        if (BGMaudioPairs[theme] == curBGMclip)
            return;
        else
        {
            curBGMclip = BGMaudioPairs[theme];
            bgmAudioSource.clip = BGMaudioPairs[theme];
            bgmAudioSource.Play();
        }
    }
}
