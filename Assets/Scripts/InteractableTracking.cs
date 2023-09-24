using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;
using UnityEngine.EventSystems;

using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;

public class InteractableTracking : MonoBehaviour
{

    public Sprite  lockImage;

    public Sprite  unlockImage;

    [SerializeField]
    private GameObject[] placeablePrefabs;

    private bool isLock = false;

    private Dictionary<string, GameObject> spawnedPrefabs = new Dictionary<string, GameObject>();
    
    private ARTrackedImageManager trackedImageManager;


    private void Awake()
    {
        trackedImageManager = FindObjectOfType<ARTrackedImageManager>();

        foreach(GameObject prefab in placeablePrefabs)
        {
            GameObject newPrefab = Instantiate(prefab, Vector3.zero, Quaternion.identity);
            newPrefab.name = prefab.name;
            spawnedPrefabs.Add(prefab.name, newPrefab);
        }
    }

    private void OnEnable()
    {
        trackedImageManager.trackedImagesChanged += OnChanged;
    }

    private void OnDisable()
    {
        trackedImageManager.trackedImagesChanged -= OnChanged;
    }

    void OnChanged(ARTrackedImagesChangedEventArgs eventArgs)
    {
        foreach (var newImage in eventArgs.added)
        {
                UpdateImage(newImage);
        }

        foreach (var updatedImage in eventArgs.updated)
        {
            if(updatedImage.trackingState == TrackingState.Tracking)
            {
                UpdateImage(updatedImage);
            }
        }

        foreach (var removedImage in eventArgs.removed)
        {
            spawnedPrefabs[removedImage.referenceImage.name].SetActive(false);
        }  
    }

    private void UpdateImage(ARTrackedImage trackedImage)
    {
        GameObject prefab = spawnedPrefabs[trackedImage.referenceImage.name];
        prefab.transform.position = trackedImage.transform.position;
        if(!isLock)
        {
            prefab.transform.rotation = trackedImage.transform.rotation;
        }

    }

    private void NewImage(ARTrackedImage trackedImage)
    {
        GameObject prefab = spawnedPrefabs[trackedImage.referenceImage.name];
        prefab.transform.position = trackedImage.transform.position;
        prefab.transform.rotation = trackedImage.transform.rotation;
    }

    public void lockUnlock()
    {
        isLock = !isLock;
        EventSystem.current.currentSelectedGameObject.GetComponent<Image>().sprite = isLock ? lockImage : unlockImage;
    }

    public void reload()
    {
        foreach(var key in spawnedPrefabs.Keys)
        {
            Destroy(spawnedPrefabs[key]);
        }
        spawnedPrefabs.Clear();

        foreach(GameObject prefab in placeablePrefabs)
        {
            GameObject newPrefab = Instantiate(prefab, Vector3.zero, Quaternion.identity);
            newPrefab.name = prefab.name;
            spawnedPrefabs.Add(prefab.name, newPrefab);
        }

    }
}
