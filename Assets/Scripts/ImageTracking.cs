using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;
using UnityEngine.XR.ARFoundation;

[RequireComponent(typeof(ARTrackedImageManager))]
public class ImageTracking : MonoBehaviour
{
    public GameObject[] placeablePrefabs;
    private Dictionary<string, GameObject> spawnedPrefabs = new Dictionary<string, GameObject>();
    private ARTrackedImageManager trackedImageManager;

    public GameObject overlay;
    public Camera cam;

    private void Awake()
    {
        trackedImageManager = FindObjectOfType<ARTrackedImageManager>();

        foreach(GameObject prefab in placeablePrefabs)
        {
            GameObject newPrefab = Instantiate(prefab, Vector3.zero, Quaternion.identity);
            newPrefab.name = prefab.name;
            newPrefab.GetComponent<TriggerAnim>()._camera = cam;
            spawnedPrefabs.Add(prefab.name, newPrefab);
        }
        disbaleAll();
    }

    private void OnEnable()
    {
        trackedImageManager.trackedImagesChanged += ImageChanged;
    }

    private void OnDisable()
    {
        trackedImageManager.trackedImagesChanged -= ImageChanged;
    }

    private void ImageChanged(ARTrackedImagesChangedEventArgs eventArgs)
    {
        foreach (ARTrackedImage trackedImage in eventArgs.removed)
        {
            spawnedPrefabs[trackedImage.referenceImage.name].SetActive(false);
            overlay.SetActive(true);
        }
        foreach (ARTrackedImage trackedImage in eventArgs.added)
        {
            UpdateImage(trackedImage);
        }
        foreach (ARTrackedImage trackedImage in eventArgs.updated)
        {
            UpdateImage(trackedImage);
        }
    }

    private void UpdateImage(ARTrackedImage trackedImage)
    {
        overlay.SetActive(false);
        disbaleAll();
        string name = trackedImage.referenceImage.name;
        Vector3 position = trackedImage.transform.position;
        Quaternion rotation = trackedImage.transform.rotation;

        GameObject prefab = spawnedPrefabs[name];
        prefab.transform.position = position;
        prefab.transform.rotation = rotation;
        prefab.SetActive(true);

        //foreach (GameObject go in spawnedPrefabs.Values)
        //{
        //    if (go.name != name)
        //    {
        //        go.SetActive(false);
        //    }
        //}
    }

    public void disbaleAll()
    {
        foreach (GameObject go in spawnedPrefabs.Values)
        {
            go.SetActive(false);
        }
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            TestSpawn();
        }
    }

    public void TestSpawn()
    {
        overlay.SetActive(false);
        disbaleAll();
        string name = "TRAXLE";
        Vector3 position = new Vector3(0,10,0);
        Quaternion rotation = Quaternion.identity;

        GameObject prefab = spawnedPrefabs[name];
        prefab.transform.position = position;
        prefab.transform.rotation = rotation;
        prefab.SetActive(true);

        //foreach (GameObject go in spawnedPrefabs.Values)
        //{
        //    if (go.name != name)
        //    {
        //        go.SetActive(false);
        //    }
        //}
    }
}
