#if UNITY_EDITOR
using UnityEngine;
using UnityEditor;

namespace ProgramadorCastellano.CentralisedUI.EditorTools
{
    [CustomEditor(typeof(CentralisedUIData))]
    [CanEditMultipleObjects]
    public class CentralisedUIDataEditor : Editor
    {
        public override void OnInspectorGUI()
        {
            serializedObject.Update();

            DrawDefaultInspector();

            if (GUILayout.Button("Apply Skin")) {
                
                foreach (var obj in targets) {
                    CentralisedUIData myScript = (CentralisedUIData)obj;
                    Undo.RecordObjects(myScript.GetComponents<Component>(), "Apply Skin Changes");
                    myScript.OnSkinUI();

                    if (GUI.changed) {
                        EditorUtility.SetDirty(myScript);
                    }
                }
            }

            serializedObject.ApplyModifiedProperties();
            Repaint();
        }
    }
}
#endif