using UnityEngine;
using UnityEngine.UI;

namespace ProgramadorCastellano.CentralisedUI
{
    [CreateAssetMenu(menuName = "ProgramadorCastellano/CentralisedUI/ColorTint", order = 1)]
    public class CentralisedUIColorTintSO : ScriptableObject
    {
        [SerializeField] ColorBlock _colors = ColorBlock.defaultColorBlock;
        public ColorBlock Colors => _colors;
    }
}
