using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn_Object : MonoBehaviour {

    public GameObject tree1;
    public GameObject tree2;
    public GameObject tree3;
    public GameObject tree4;
    public GameObject tree5;

    public MeshFilter meshf;

    public Renderer shape_mesh_Object;
    
    public int boom1;
    public int boom2;
    public int boom3;
    public int boom4;
    public int boom5;

    public Vector3 center;
    public Vector3 size;


    public void Clone()
    {
        //hier moet elk object wat je wil laten verwijderen een tag: clone krijgen.
        var clones = GameObject.FindGameObjectsWithTag("clone");
        foreach (var clone in clones)
        {
            DestroyImmediate(clone);
        }
     }
    public void SpawnTree1()
    {
        float randomX = Random.Range(shape_mesh_Object.bounds.min.x, shape_mesh_Object.bounds.max.x);
        float randomZ = Random.Range(shape_mesh_Object.bounds.min.z, shape_mesh_Object.bounds.max.z);

        RaycastHit hit;
        if (Physics.Raycast(new Vector3(randomX, shape_mesh_Object.bounds.max.y + 5f, randomZ), -Vector3.up, out hit))
        {
            //transform: maak een child van tree
            Instantiate(tree1, hit.point, Quaternion.identity, transform);
        }
        else
        {
            //als de raycast niet hit, voer dan opnieuw uit tot hij hem wel hit
            SpawnTree1();
            Debug.Log("non 1");
          
        }


    }
    public void SpawnTree2()
    {
        float randomX = Random.Range(shape_mesh_Object.bounds.min.x, shape_mesh_Object.bounds.max.x);
        float randomZ = Random.Range(shape_mesh_Object.bounds.min.z, shape_mesh_Object.bounds.max.z);

        RaycastHit hit;
        if (Physics.Raycast(new Vector3(randomX, shape_mesh_Object.bounds.max.y + 5f, randomZ), -Vector3.up, out hit))
        {
            //transform: maak een child van tree
            Instantiate(tree2, hit.point, Quaternion.identity, transform);
        }
        else
        {
            //als de raycast niet hit, voer dan opnieuw uit tot hij hem wel hit
            SpawnTree2();
            Debug.Log("non 2");
        
        }


    }
    public void SpawnTree3()
    {
        float randomX = Random.Range(shape_mesh_Object.bounds.min.x, shape_mesh_Object.bounds.max.x);
        float randomZ = Random.Range(shape_mesh_Object.bounds.min.z, shape_mesh_Object.bounds.max.z);

        RaycastHit hit;
        if (Physics.Raycast(new Vector3(randomX, shape_mesh_Object.bounds.max.y + 5f, randomZ), -Vector3.up, out hit))
        {
            //transform: maak een child van tree
            Instantiate(tree3, hit.point, Quaternion.identity, transform);
        }
        else
        {
            //als de raycast niet hit, voer dan opnieuw uit tot hij hem wel hit
            SpawnTree3();
            Debug.Log("non 3");

        }
    }
    public void SpawnTree4()
    {
        float randomX = Random.Range(shape_mesh_Object.bounds.min.x, shape_mesh_Object.bounds.max.x);
        float randomZ = Random.Range(shape_mesh_Object.bounds.min.z, shape_mesh_Object.bounds.max.z);

        RaycastHit hit;
        if (Physics.Raycast(new Vector3(randomX, shape_mesh_Object.bounds.max.y + 5f, randomZ), -Vector3.up, out hit))
        {
            //transform: maak een child van tree
            Instantiate(tree4, hit.point, Quaternion.identity, transform);
        }
        else
        {
            //als de raycast niet hit, voer dan opnieuw uit tot hij hem wel hit
            SpawnTree4();
            Debug.Log("non 4");
           
        }
    }

    public void Addcolider()
    {
        transform.gameObject.AddComponent<MeshCollider>();
       
    }
    public void destroycolider()
    {
        MeshCollider meshaa = GetComponent<MeshCollider>();
        Destroy(meshaa);
    }
 public void SpawnTree5()
    {

        float randomX = Random.Range(shape_mesh_Object.bounds.min.x, shape_mesh_Object.bounds.max.x);
        float randomZ = Random.Range(shape_mesh_Object.bounds.min.z, shape_mesh_Object.bounds.max.z);

        RaycastHit hit;
        if (Physics.Raycast(new Vector3(randomX, shape_mesh_Object.bounds.max.y + 5f, randomZ), -Vector3.up, out hit))
        {
            //transform: maak een child van tree
            Instantiate(tree5,hit.point, Quaternion.identity, transform);
            }
        else
        {
            //als de raycast niet hit, voer dan opnieuw uit tot hij hem wel hit
            SpawnTree5();

            Debug.Log("non 5");
          
        }
    }
    private void OnDrawGizmosSelected()
    {
        Gizmos.color = new Color(1, 4, 7, 3.5f);
        Gizmos.DrawMesh(meshf.sharedMesh, size);      
     }

}
