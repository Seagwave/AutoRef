#if UNITY_EDITOR
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

namespace AutoRef.Editor
{
    [InitializeOnLoad]
    public class AutoRefMarker
    {
        private static List<GameObject> markedObjects = new List<GameObject>();

        static AutoRefMarker()
        {
            EditorApplication.hierarchyWindowItemOnGUI += OnHierarchyItemGUI;
        }

        public static void MarkObject(GameObject gameObject)
        {
            if (!markedObjects.Contains(gameObject))
            {
                markedObjects.Add(gameObject);
            }
        }

        private static void OnHierarchyItemGUI(int instanceID, Rect selectionRect)
        {
            var gameObject = EditorUtility.InstanceIDToObject(instanceID) as GameObject;
            if (gameObject == null) return;

            if (markedObjects.Contains(gameObject))
            {
                ApplyColor(selectionRect, gameObject, Color.green);
            }
        }

        private static void ApplyColor(Rect rect, GameObject go, Color color)
        {
            Color textColor = color;

            GUIStyle style = new GUIStyle(EditorStyles.label);
            style.normal.textColor = textColor;

            // 调整文本位置
            Rect textRect = new Rect(rect.x + 17, rect.y - 1, rect.width - 17, rect.height + 1);
            EditorGUI.LabelField(textRect, go.name, style);
        }
    }
}
#endif // UNITY_EDITOR