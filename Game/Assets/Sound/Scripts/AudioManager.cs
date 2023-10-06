using System.Buffers.Text;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;

public class AudioManager : MonoBehaviour
{
    [SerializeField] RawImage rawImage;
    [SerializeField] AudioClip[] audioClip;
    [SerializeField] AudioSource audioSource;

    private void Awake()
    {
        StartCoroutine(GetTuxtures("https://cdn.pixabay.com/photo/2020/03/26/18/21/pixabay-4971315_1280.jpg"));
    }

    public void Search()
    {
        GameObject objectSearched = GameObject.Find("Drone");
        objectSearched.transform.GetChild(0).gameObject.SetActive(true);
        AudioSource.PlayClipAtPoint(audioClip[0], objectSearched.transform.position);
    }

    public void Signal()
    {
        audioSource.PlayOneShot(audioClip[1]);
    }

    IEnumerator GetTuxtures(string url)
    {
        UnityWebRequest www = UnityWebRequestTexture.GetTexture(url);

        yield return www.SendWebRequest();

        if(www.result != UnityWebRequest.Result.Success)
        {
            Debug.Log(www.error);
        }
        else
        {
            Texture textures = ((DownloadHandlerTexture)www.downloadHandler).texture;
            rawImage.texture = textures;
        }
    }
}
