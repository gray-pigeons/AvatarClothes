using UnityEngine;

namespace Metaverse
{
    /// <summary>
    /// Avatar·ş×°ÅäÖÃ
    /// </summary>
    [CreateAssetMenu(menuName = "Metaverse/Avatar Clothing Config")]
    public class AvatarClothingConfig : ScriptableObject
    {
        public AvatarOutlookData[] data = new AvatarOutlookData[0];
    }

}
