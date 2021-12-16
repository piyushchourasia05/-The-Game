using UnityEngine;

public class SelectionManager : MonoBehaviour
{
    [SerializeField] private string selectableTag = "Car";
    [SerializeField] private Material highlightMaterial;
    [SerializeField] private Material defaultMaterial;
    [SerializeField] private GameObject Camera;

    private Transform _selection;

    private void Update()
    {

        RaycastHit hit;
        Ray ray = new Ray(transform.position, Camera.transform.position);

        if(Physics.Raycast(ray, out hit))
		{
            Debug.Log(hit.collider.name);
		}


        //if (_selection != null)
        //{
        //    var selectionRenderer = _selection.GetComponent<Renderer>();
        //    selectionRenderer.material = defaultMaterial;
        //    _selection = null;
        //}

        //var ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        //RaycastHit hit;
        //if (Physics.Raycast(ray, out hit))
        //{
        //    var selection = hit.transform;
        //    if (hit.collider.tag == "Car") //selection.CompareTag(selectableTag)
        //    {
        //        Debug.Log("Car was hit");
        //        //var selectionrenderer = selection.getcomponent<renderer>();
        //        //if (selectionrenderer != null)
        //        //{
        //        //    selectionrenderer.material = highlightmaterial;
        //        //}

        //        //_selection = selection;
        //    }
        //}
    }
}