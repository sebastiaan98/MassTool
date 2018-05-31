using UnityEngine;
using System.Collections;
using UnityEditor;

[CustomEditor(typeof(Spawn_Object))]
public class ObjectBuilderEditor : Editor
{



    public override void OnInspectorGUI()
    {
        DrawDefaultInspector();
        Spawn_Object myScript = (Spawn_Object)target;
        Spawn_Object dad = (Spawn_Object)target;
        Spawn_Object ada = (Spawn_Object)target;

        if (GUILayout.Button("Add Colider"))
        {
            ada.Addcolider();

        }
   

        GUILayout.BeginHorizontal();

        //doet nu nog niks
        if (GUILayout.Button("delete in  play"))
        {
            dad.Clone();

        }
           
        
       
        if (GUILayout.Button("Build Object"))
        {
            for (int i = 0; i < myScript.boom1; i++)
            {
                myScript.SpawnTree1();
            }
            for (int i = 0; i < myScript.boom2; i++)
            {
                myScript.SpawnTree2();
            }
            for (int i = 0; i < myScript.boom3; i++)
            {
                myScript.SpawnTree3();
            }
            for (int i = 0; i < myScript.boom4; i++)
            {
                myScript.SpawnTree4();
            }
            for (int i = 0; i < myScript.boom5; i++)
            {
                myScript.SpawnTree5();
            }
        
        }
        GUILayout.EndHorizontal();
    }
}