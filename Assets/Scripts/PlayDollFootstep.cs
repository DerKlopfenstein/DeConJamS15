using UnityEngine;
using System.Collections;

public class PlayDollFootstep : MonoBehaviour 
{
    [SerializeField] private AudioClip[] m_FootstepSounds;

    private AudioSource m_AudioSource;

	// Use this for initialization
	void Start () 
    {
        m_AudioSource = GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () 
    {
	
	}

    public void PlayFootstep()
    {
        int n = Random.Range(1, m_FootstepSounds.Length);
        m_AudioSource.clip = m_FootstepSounds[n];
        m_AudioSource.PlayOneShot(m_AudioSource.clip);
        // move picked sound to index 0 so it's not picked next time
        m_FootstepSounds[n] = m_FootstepSounds[0];
        m_FootstepSounds[0] = m_AudioSource.clip;
    }
}
