using UnityEngine;
using UnityEngine.UI;

namespace ProgramadorCastellano.CentralisedUI
{
    [CreateAssetMenu(menuName = "ProgramadorCastellano/CentralisedUI/SpriteSwap", order = 2)]
    public class CentralisedUISpriteSwapSO : ScriptableObject
    {
        [SerializeField] SpriteState _sprites;
        public SpriteState Sprites => _sprites;
    }
}
