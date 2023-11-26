using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

namespace ProgramadorCastellano.CentralisedUI.EditorTools
{
    public class CentralisedUIDataComponentEditor
    {
        private const string MENU_PATH = "Component/UI/ProgramadorCastellano/CentralisedUI";

        [MenuItem(MENU_PATH, false)]
        private static void AddCentralisedUIDataComponent()
        {
            GameObject activeGO = Selection.activeGameObject;

            if (activeGO == null) {
                Debug.LogWarning($"No GameObject selected");
                return;
            }

            if (activeGO.GetComponent<CentralisedUIData>() != null) {
                Debug.LogWarning($"{activeGO.name} already has the CentralisedUIData Component");
                return;
            }

            Undo.AddComponent<CentralisedUIData>(activeGO);
        }

        [MenuItem(MENU_PATH, true)]
        private static bool ValidateAddCentralisedUIDataComponent()
        {
            return Selection.activeGameObject != null;
        }
    }
}
