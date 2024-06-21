using System;
using UnityEngine;

namespace Metaverse
{
    /// <summary>
    /// Avatar外观数据
    /// </summary>
    [Serializable]
    public class AvatarOutlookData
    {
        /// <summary>
        /// 头部网格
        /// </summary>
        public Mesh headMesh;
        /// <summary>
        /// 头部材质
        /// </summary>
        public Material headMaterial;

        /// <summary>
        /// 身体网格
        /// </summary>
        public Mesh bodyMesh;
        /// <summary>
        /// 身体材质
        /// </summary>
        public Material bodyMaterial;

        /// <summary>
        /// 上衣网格
        /// </summary>
        public Mesh topMesh;
        /// <summary>
        /// 上衣材质
        /// </summary>
        public Material topMaterial;

        /// <summary>
        /// 裤子网格
        /// </summary>
        public Mesh bottomMesh;
        /// <summary>
        /// 裤子材质
        /// </summary>
        public Material bottomMaterial;

        /// <summary>
        /// 鞋子网格
        /// </summary>
        public Mesh footwearMesh;
        /// <summary>
        /// 鞋子材质
        /// </summary>
        public Material footwearMaterial;

        /// <summary>
        /// 缩略图
        /// </summary>
        public Sprite thumb;
    }

    [Serializable]
    public class ManAvatarData
    {
        public Mesh eayLeftMesh;

        public Material eayLeftMaterial;

        public Mesh eayRightMesh;

        public Material eayRightMaterial;

        public Mesh wolf3DBodyMesh;

        public Material wolf3DBodyMaterial;

        public Mesh wolf3DGlassesMesh;

        public Material wolf3DGlassesMaterial;

        public Mesh wolf3DHairMesh;

        public Material wolf3DHairMaterial;

        public Mesh wolf3DHeadMesh;

        public Material wolf3DHeadMaterial;

        public Mesh wolf3DOutfitBottomMesh;

        public Material wolf3DOutfitBottomMaterial;
        public Mesh wolf3DOutfitFootwearMesh;

        public Material wolf3DOutfitFootwearMaterial;
        public Mesh wolf3DOutfitTopMesh;

        public Material wolf3DOutfitTopMaterial;
        public Mesh wolf3DOutfitTeethMesh;

        public Material wolf3DOutfitTeethMaterial;



    }
}
