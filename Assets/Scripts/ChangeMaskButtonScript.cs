using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;

public class ChangeMaskButtonScript : MonoBehaviour
{
    private ARFaceManager faceManager;
    public List<Material> faceMaterials = new List<Material>();
    private int faceMaterialIndex = 0;
    // Start is called before the first frame update
    void Start()
    {
        faceManager = GetComponent<ARFaceManager>();
    }

    public void ChangeMask()
    {
        foreach (ARFace face in faceManager.trackables)
        {
            face.GetComponent<Renderer>().material = faceMaterials[faceMaterialIndex];
        }
        faceMaterialIndex++;
        if (faceMaterialIndex==faceMaterials.Count)
        {
            faceMaterialIndex = 0;
        }
    }
}
