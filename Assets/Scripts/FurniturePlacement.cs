using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

using UnityEngine.UI;
using UnityEngine.EventSystems;

using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;

using Lean.Common;


public class FurniturePlacement : MonoBehaviour
{

    public GameObject spawnableFurniture;

    public ARSessionOrigin sessionOrigin;

    public ARRaycastManager raycastManager;

    private ARPlaneManager planeManager;

    private List<ARRaycastHit> raycastHits = new List<ARRaycastHit>();

    private List<GameObject> generatedObjects = new List<GameObject>();

    private void Update(){

        planeManager = FindObjectOfType<ARPlaneManager>();

        if(Input.touchCount == 1 && Input.GetTouch(0).phase == TouchPhase.Ended)
        {
            bool collision = raycastManager.Raycast(Input.GetTouch(0).position, raycastHits, TrackableType.PlaneWithinPolygon);
            if(collision && isButtonPressed() == false)
            {
                GameObject _object = Instantiate(spawnableFurniture);
                if(generatedObjects.Count>0){
                    generatedObjects.Last().GetComponent<LeanSelectable>().SelfSelected = false;
                }
                generatedObjects.Add(_object);
                _object.transform.position = raycastHits[0].pose.position;
                _object.transform.rotation = raycastHits[0].pose.rotation;
                _object.GetComponent<LeanSelectable>().SelfSelected = true;

                planeManager.enabled = false;
            }
        }
    }
    public bool isButtonPressed()
    {
        if(EventSystem.current.currentSelectedGameObject?.GetComponent<Button>() == null)
        {
            Debug.Log("false");
            return false;
        }
        else
        {
            Debug.Log("true");
            return true;
        }
    }

    public void clearAllObjects()
    {
        if(generatedObjects.Any())
        {
            Debug.Log("All objects cleared");
            foreach(var obj in generatedObjects)
            {
                Destroy(obj);
            }
            generatedObjects.Clear();
        }
    }


    public void deleteLastObject()
    {
        if(generatedObjects.Any())
        {
            Debug.Log("Deleting last object : " + generatedObjects.Last());
            Destroy(generatedObjects.Last());
            generatedObjects.RemoveAt(generatedObjects.Count - 1);
        }
    }


    public void reloadPlanes()
    {
        clearAllObjects();
        Debug.Log("Deleting planes : " + planeManager.trackables);
        
        planeManager.SetTrackablesActive(false);

        foreach(var plane in planeManager.trackables)
        {
            Destroy(plane);
        }

        planeManager.enabled = true;
    }


    public void SwitchFurniture(GameObject furniture)
    {
        Debug.Log("Selected furniture : " + furniture.name);
        spawnableFurniture = furniture;
    }

}

