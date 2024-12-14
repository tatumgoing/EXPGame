using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class AudioManager : MonoBehaviour
{
    public AudioMixer mixer;

    public AudioSource enemyNoise;
    public AudioSource lanternNoise;
    public AudioSource deathNoise;

    public float distanceVolume = 0;

    public EnemyBehavior enemyBehavior;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        distanceVolume = enemyBehavior.GetDistance() / 100;
        distanceVolume= Mathf.Clamp(distanceVolume, 0, 1);
        mixer.SetFloat("Enemy", distanceVolume);
    }

    public void PlayDeath()
    {
        deathNoise.Play();
    }

    public void PlayLantern()
    {
        lanternNoise.Play();
    }
    


}