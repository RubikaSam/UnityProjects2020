using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using UnityEngine.SceneManagement;


public class ToolSet : MonoBehaviour
{
   
    [MenuItem("ADMenu/Print something")]
    static void PrintSomething()
    {
        Debug.Log("En principe ça fonctionne");
    }

    // Utilisation de raccourci via & (alt) / % (ctrl) / # (shift)
    [MenuItem("ADMenu/Print something with SC &%a")]
    static void PrintSomethingWithSC()
    {
        Debug.Log("En principe ça fonctionne");
    }

    [MenuItem("ADMenu/Look on scene")]
    static void LookOnScene()
    {
        // goTemp = Game Object Temporaire, la création de la variable est temporaire et personnel à ce bloc 
        GameObject[] objects = SceneManager.GetActiveScene().GetRootGameObjects();
        foreach(GameObject goTmp in objects)
        {
            Debug.Log("Root object name : " + goTmp.name);
        }
    }

    [MenuItem("ADMenu/Log selected transform name")]
    static void LogSelectedTransformName()
    {
        //Permet de vérifier si un objet est sélectionné, sinon renvoie un NullException Error
        if(Selection.activeTransform != null)
        Debug.Log("Selected Transform name : " + Selection.activeTransform.gameObject.name);
    }

    [MenuItem("ADMenu/Log selected object")]
    static void LogSelectedObject()
    {
        if (Selection.activeObject != null)
            Debug.Log("Selected Object is : " + Selection.activeObject.name);
    }

    [MenuItem("ADMenu/Toggle Game Objects &t")]
    static void ToggleGameObject()
    {
        foreach(GameObject goTmp in Selection.gameObjects)
        {
            if (goTmp.activeInHierarchy)
                goTmp.SetActive(false);
            else
                goTmp.SetActive(true);
        }
    }

    [MenuItem("CONTEXT/Rigidbody/Multiply mass by 4")]
    static void MultiplyByFour(MenuCommand command)
    {
        // Bien préciser à quel contexte l'on souhaite toucher. Ici, Rigidbody
        Rigidbody rb = (Rigidbody)command.context;
        rb.mass = rb.mass * 4;
    }
}
