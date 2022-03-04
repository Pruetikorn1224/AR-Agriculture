using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PopupShowing : MonoBehaviour
{
    public List<GameObject> popupSign;

    private void Start()
    {
        for(int i = 0; i < popupSign.Count; i++)
        {
            popupSign[i].SetActive(false);
        }
    }

    private void Update()
    {
        if (Input.touchCount > 0 && Input.touches[0].phase == TouchPhase.Began)
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.GetTouch(0).position);
            RaycastHit Hit;

            if (Physics.Raycast(ray, out Hit))
            {
                var popupName = "Pop Up " + Hit.transform.name;
                
                for (int i = 0; i < popupSign.Count; i++)
                {
                    popupSign[i].SetActive(false);
                    if (popupSign[i].name == popupName)
                    {
                        popupSign[i].SetActive(true);
                    }
                }
            }
        }
    }
}
