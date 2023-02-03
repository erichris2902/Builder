using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;

public class MultiTargetsManager : MonoBehaviour
{
    public ARTrackedImageManager aRTrackedImageManager;
    public GameObject[] aRModelsToPlace;
    public Camera cam;

    Dictionary<string, GameObject> arModels = new Dictionary<string, GameObject>();
    Dictionary<string, bool> modelState = new Dictionary<string, bool>();

    public GameObject overlay;

    // Start is called before the first frame update
    void Start()
    {
        foreach (var aRModel in aRModelsToPlace)
        {
            GameObject newARModel = Instantiate(aRModel, Vector3.zero, Quaternion.identity);
            newARModel.name = aRModel.name;
            arModels.Add(newARModel.name, newARModel);
            aRModel.GetComponent<TriggerAnim>()._camera = cam;
            newARModel.SetActive(false);
            modelState.Add(newARModel.name, false);
        }
    }

    private void OnEnable()
    {
        overlay.SetActive(true);
        aRTrackedImageManager.trackedImagesChanged += ImageFound;
    }

    private void OnDisable()
    {
        aRTrackedImageManager.trackedImagesChanged -= ImageFound;
    }

    private void ImageFound(ARTrackedImagesChangedEventArgs eventArgs)
    {
        foreach (ARTrackedImage trackedImage in eventArgs.removed)
        {
            HideArModel(trackedImage);
        }
        foreach (ARTrackedImage trackedImage in eventArgs.added)
        {
            ShowArModel(trackedImage);
            
        }
        foreach (ARTrackedImage trackedImage in eventArgs.updated)
        {
            if (trackedImage.trackingState == UnityEngine.XR.ARSubsystems.TrackingState.Limited)
            {
                HideArModel(trackedImage);
            }
            if (trackedImage.trackingState == UnityEngine.XR.ARSubsystems.TrackingState.Tracking)
            {
                ShowArModel(trackedImage);
            }
        }
    }

    private void ShowArModel(ARTrackedImage trackedImage)
    {
        overlay.SetActive(false);
        GameObject aRModel = arModels[trackedImage.referenceImage.name];
        aRModel.SetActive(true);
        aRModel.transform.position = trackedImage.transform.position;
        aRModel.transform.rotation = trackedImage.transform.rotation;
        modelState[trackedImage.referenceImage.name] = true;
    }

    private void HideArModel(ARTrackedImage trackedImage)
    {
        GameObject aRModel = arModels[trackedImage.referenceImage.name];
        aRModel.SetActive(false);
        modelState[trackedImage.referenceImage.name] = false;
    }

}