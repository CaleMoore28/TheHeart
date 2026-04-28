using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class SoundPlay : MonoBehaviour
{

  private AudioSource audioSource;
  void Start()
  {
    audioSource = GetComponent<AudioSource>();
  }

  void OnInteract()
  {
    audioSource.Play();
  }

}
