#if UNITY_EDITOR
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

namespace ProgramadorCastellano.CentralisedUI.EditorTools
{
    public class DefaultCentralisedUIDataItemsEditor
    {
        private const string MENU_BASE_PATH = "GameObject/UI/ProgramadorCastellano/CentralisedUI/";

        private const string TOGGLE_NAME = "UI Data Toggle";
        private const string SLIDER_NAME = "UI Data Slider";
        private const string SCROLLBAR_NAME = "UI Data Scrollbar";
        private const string SCROLLVIEW_NAME = "UI Data ScrollView";
        private const string BUTTON_NAME = "UI Data Button";
        private const string DROPDOWN_NAME = "UI Data Dropdown";
        private const string INPUT_FIELD = "UI Data InputField";

        private const string BACKGROUND_PATH = "UI/Skin/Background.psd";
        private const string CHECKMARK_PATH = "UI/Skin/Checkmark.psd";
        private const string DROPDOWNARROW_PATH = "UI/Skin/DropdownArrow.psd";
        private const string INPUTFIELD_PATH = "UI/Skin/InputFieldBackground.psd";
        private const string KNOB_PATH = "UI/Skin/Knob.psd";
        private const string UIMASK_PATH = "UI/Skin/UIMask.psd";
        private const string UISPRITE_PATH = "UI/Skin/UISprite.psd";

        private static int _uiLayer = 5;

        [MenuItem(MENU_BASE_PATH + TOGGLE_NAME)]
        private static void CreateDefaultCentralisedToggle()
        {
            GameObject toggleGO = DefaultControls.CreateToggle(new DefaultControls.Resources());
            toggleGO.AddComponent<CentralisedUIData>();
            SetLayerRecursively(toggleGO, _uiLayer);
            toggleGO.name = TOGGLE_NAME;

            Transform t = toggleGO.transform;
            Transform backgroundT = t.GetChild(0);
            Transform checkMarckT = backgroundT.GetChild(0);

            AssignSprite(backgroundT.gameObject, UISPRITE_PATH);
            AssignSprite(checkMarckT.gameObject, CHECKMARK_PATH);

            CheckParentAndAlign(toggleGO);
            RegisterUndoAndSelectionActive(toggleGO, $"Create {TOGGLE_NAME}");
        }

        [MenuItem(MENU_BASE_PATH + SLIDER_NAME)]
        private static void CreateDefaultCentralisedSlider()
        {
            GameObject sliderGO = DefaultControls.CreateSlider(new DefaultControls.Resources());
            sliderGO.AddComponent<CentralisedUIData>();
            SetLayerRecursively(sliderGO, _uiLayer);
            sliderGO.name = SLIDER_NAME;

            Transform t = sliderGO.transform;
            Transform backgroundT = t.GetChild(0);
            Transform fillT = t.GetChild(1).GetChild(0);
            Transform handleT = t.GetChild(2).GetChild(0);

            AssignSprite(backgroundT.gameObject, BACKGROUND_PATH);
            AssignSprite(fillT.gameObject, UISPRITE_PATH);
            AssignSprite(handleT.gameObject, KNOB_PATH);

            CheckParentAndAlign(sliderGO);
            RegisterUndoAndSelectionActive(sliderGO, $"Create {SLIDER_NAME}");
        }

        [MenuItem(MENU_BASE_PATH + SCROLLBAR_NAME)]
        private static void CreateDefaultCentralisedScrollbar()
        {
            GameObject scrollbarGO = TMP_DefaultControls.CreateScrollbar(new TMP_DefaultControls.Resources());
            scrollbarGO.AddComponent<CentralisedUIData>();
            SetLayerRecursively(scrollbarGO, _uiLayer);
            scrollbarGO.name = SCROLLBAR_NAME;

            Transform t = scrollbarGO.transform;
            Transform handleT = t.GetChild(0).GetChild(0);

            AssignSprite(scrollbarGO, BACKGROUND_PATH);
            AssignSprite(handleT.gameObject, UISPRITE_PATH);

            CheckParentAndAlign(scrollbarGO);
            RegisterUndoAndSelectionActive(scrollbarGO, $"Create {SCROLLBAR_NAME}");
        }

        [MenuItem(MENU_BASE_PATH + SCROLLVIEW_NAME)]
        private static void CreateDefaultCentralisedScrollView()
        {
            GameObject scrollViewGO = DefaultControls.CreateScrollView(new DefaultControls.Resources());
            scrollViewGO.AddComponent<CentralisedUIData>();
            SetLayerRecursively(scrollViewGO, _uiLayer);
            scrollViewGO.name = SCROLLVIEW_NAME;

            Transform t = scrollViewGO.transform;
            Transform viewportT = t.GetChild(0);
            Transform scrollbarHorizontalT = t.GetChild(1);
            Transform handleHortzontalT = scrollbarHorizontalT.GetChild(0).GetChild(0);
            Transform scrollbarVerticalT = t.GetChild(2);
            Transform handleVerticalT = scrollbarVerticalT.GetChild(0).GetChild(0);

            AssignSprite(scrollViewGO, BACKGROUND_PATH);
            AssignSprite(viewportT.gameObject, UIMASK_PATH);
            AssignSprite(scrollbarHorizontalT.gameObject, BACKGROUND_PATH);
            AssignSprite(handleHortzontalT.gameObject, UISPRITE_PATH);
            AssignSprite(scrollbarVerticalT.gameObject, BACKGROUND_PATH);
            AssignSprite(handleVerticalT.gameObject, UISPRITE_PATH);

            CheckParentAndAlign(scrollViewGO);
            RegisterUndoAndSelectionActive(scrollViewGO, $"Create {SCROLLVIEW_NAME}");
        }

        [MenuItem(MENU_BASE_PATH + BUTTON_NAME)]
        private static void CreateDefaultCentralisedButton()
        {
            GameObject buttonGO = TMP_DefaultControls.CreateButton(new TMP_DefaultControls.Resources());
            buttonGO.AddComponent<CentralisedUIData>();
            SetLayerRecursively(buttonGO, _uiLayer);
            buttonGO.name = BUTTON_NAME;

            AssignSprite(buttonGO, UISPRITE_PATH);

            CheckParentAndAlign(buttonGO);
            RegisterUndoAndSelectionActive(buttonGO, $"Create {BUTTON_NAME}");
        }

        [MenuItem(MENU_BASE_PATH + DROPDOWN_NAME)]
        private static void CreateDefaultCentralisedDropdown()
        {
            GameObject dropdownGO = TMP_DefaultControls.CreateDropdown(new TMP_DefaultControls.Resources());
            dropdownGO.AddComponent<CentralisedUIData>();
            SetLayerRecursively(dropdownGO, _uiLayer);
            dropdownGO.name = DROPDOWN_NAME;

            Transform t = dropdownGO.transform;
            Transform arrowT = t.GetChild(1);
            Transform templateT = t.GetChild(2);
            Transform viewportT = templateT.GetChild(0);
            Transform itemCheckMarkT = viewportT.GetChild(0).GetChild(0).GetChild(1);
            Transform scrollbarT = templateT.GetChild(1);
            Transform handleT = scrollbarT.GetChild(0).GetChild(0);

            AssignSprite(dropdownGO, UISPRITE_PATH);
            AssignSprite(arrowT.gameObject, DROPDOWNARROW_PATH);
            AssignSprite(templateT.gameObject, UISPRITE_PATH);
            AssignSprite(viewportT.gameObject, UIMASK_PATH);
            AssignSprite(itemCheckMarkT.gameObject, CHECKMARK_PATH);
            AssignSprite(scrollbarT.gameObject, BACKGROUND_PATH);
            AssignSprite(handleT.gameObject, UISPRITE_PATH);

            CheckParentAndAlign(dropdownGO);
            RegisterUndoAndSelectionActive(dropdownGO, $"Create {DROPDOWN_NAME}");
        }

        [MenuItem(MENU_BASE_PATH + INPUT_FIELD)]
        private static void CreateDefaultCentralisedInputField()
        {
            GameObject inputFieldGO = TMP_DefaultControls.CreateInputField(new TMP_DefaultControls.Resources());
            inputFieldGO.AddComponent<CentralisedUIData>();
            SetLayerRecursively(inputFieldGO, _uiLayer);
            inputFieldGO.name = INPUT_FIELD;

            AssignSprite(inputFieldGO, INPUTFIELD_PATH);

            CheckParentAndAlign(inputFieldGO);
            RegisterUndoAndSelectionActive(inputFieldGO, $"Create {INPUT_FIELD}");
        }

        #region AuxiliarFunctions
        private static void AssignSprite(GameObject go, string spritePath)
        {
            Sprite sprite = AssetDatabase.GetBuiltinExtraResource<Sprite>(spritePath);
            go.GetComponent<Image>().sprite = sprite;
        }

        private static void CheckParentAndAlign(GameObject buttonGO)
        {
            GameObject selectedObject = Selection.activeObject as GameObject;

            if (selectedObject != null) {
                GameObjectUtility.SetParentAndAlign(buttonGO, selectedObject);
            }
        }

        private static void RegisterUndoAndSelectionActive(GameObject go, string undoName)
        {
            Undo.RegisterCreatedObjectUndo(go, undoName);
            Selection.activeObject = go;
        }

        private static void SetLayerRecursively(GameObject go, int layer)
        {
            go.layer = layer;
            Transform transform = go.transform;

            for (int i = 0; i < transform.childCount; i++) {
                SetLayerRecursively(transform.GetChild(i).gameObject, layer);
            }
        }
        #endregion
    }
}
#endif