using UnityEngine;

public class Example : MonoBehaviour
{
    //[SerializeField] private SkinnedMeshRenderer head;
    //[SerializeField] private SkinnedMeshRenderer body;
    //[SerializeField] private SkinnedMeshRenderer top;
    //[SerializeField] private SkinnedMeshRenderer bottom;
    //[SerializeField] private SkinnedMeshRenderer footwear;

    [SerializeField] private SkinnedMeshRenderer eayLeftSkinnedMeshRenderer;


    [SerializeField] private SkinnedMeshRenderer eayRightSkinnedMeshRenderer;


    [SerializeField] private SkinnedMeshRenderer wolf3DBodySkinnedMeshRenderer;


    [SerializeField] private SkinnedMeshRenderer wolf3DGlassesSkinnedMeshRenderer;


    [SerializeField] private SkinnedMeshRenderer wolf3DHairSkinnedMeshRenderer;


    [SerializeField] private SkinnedMeshRenderer wolf3DHeadSkinnedMeshRenderer;


    [SerializeField] private SkinnedMeshRenderer wolf3DOutfitBottomSkinnedMeshRenderer;

    [SerializeField] private SkinnedMeshRenderer wolf3DOutfitFootwearSkinnedMeshRenderer;

    [SerializeField] private SkinnedMeshRenderer wolf3DOutfitTopSkinnedMeshRenderer;

    [SerializeField] private SkinnedMeshRenderer wolf3DOutfitTeethSkinnedMeshRenderer;


    [SerializeField] private Metaverse.Man001AvatarClothingConfig config;

    private void OnGUI()
    {
        if (GUILayout.Button("服装一", GUILayout.Width(200f), GUILayout.Height(50f))) Apply(0);
        if (GUILayout.Button("服装二", GUILayout.Width(200f), GUILayout.Height(50f))) Apply(1);
        //if (GUILayout.Button("服装三", GUILayout.Width(200f), GUILayout.Height(50f))) Apply(2);
    }

    private void Apply(int index)
    {
        //head.sharedMesh = config.data[index].wolf3DHairSkinnedMeshRenderer;
        //head.sharedMaterial = config.data[index].wolf3DHeadMaterial;

        //body.sharedSkinnedMeshRenderer = config.data[index].wolf3DBodySkinnedMeshRenderer;
        //body.sharedMaterial = config.data[index].wolf3DBodyMaterial;

        //top.sharedSkinnedMeshRenderer = config.data[index].wolf3DOutfitTopSkinnedMeshRenderer;
        //top.sharedMaterial = config.data[index].wolf3DOutfitTopMaterial;

        //bottom.sharedSkinnedMeshRenderer = config.data[index].wolf3DOutfitBottomSkinnedMeshRenderer;
        //bottom.sharedMaterial = config.data[index].wolf3DOutfitBottomMaterial;

        //footwear.sharedSkinnedMeshRenderer = config.data[index].wolf3DOutfitFootwearSkinnedMeshRenderer;
        //footwear.sharedMaterial = config.data[index].wolf3DOutfitFootwearMaterial;

        eayLeftSkinnedMeshRenderer.sharedMesh = config.data[index].eayLeftMesh;
        eayLeftSkinnedMeshRenderer.sharedMaterial = config.data[index].eayLeftMaterial;


        eayRightSkinnedMeshRenderer.sharedMesh = config.data[index].eayRightMesh;
        eayRightSkinnedMeshRenderer.sharedMaterial = config.data[index].eayRightMaterial;


        wolf3DBodySkinnedMeshRenderer.sharedMesh = config.data[index].wolf3DBodyMesh;
        wolf3DBodySkinnedMeshRenderer.sharedMaterial = config.data[index].wolf3DBodyMaterial;


        wolf3DGlassesSkinnedMeshRenderer.sharedMesh = config.data[index].wolf3DGlassesMesh;
        wolf3DGlassesSkinnedMeshRenderer.sharedMaterial = config.data[index].wolf3DGlassesMaterial;


        wolf3DHairSkinnedMeshRenderer.sharedMesh = config.data[index].wolf3DHairMesh;
        wolf3DHairSkinnedMeshRenderer.sharedMaterial = config.data[index].wolf3DHairMaterial;


        wolf3DHeadSkinnedMeshRenderer.sharedMesh = config.data[index].wolf3DHeadMesh;
        wolf3DHeadSkinnedMeshRenderer.sharedMaterial = config.data[index].wolf3DHeadMaterial;


        wolf3DOutfitBottomSkinnedMeshRenderer.sharedMesh = config.data[index].wolf3DOutfitBottomMesh;
        wolf3DOutfitBottomSkinnedMeshRenderer.sharedMaterial = config.data[index].wolf3DOutfitBottomMaterial;

        wolf3DOutfitFootwearSkinnedMeshRenderer.sharedMesh = config.data[index].wolf3DOutfitFootwearMesh;
        wolf3DOutfitFootwearSkinnedMeshRenderer.sharedMaterial = config.data[index].wolf3DOutfitFootwearMaterial;

        wolf3DOutfitTopSkinnedMeshRenderer.sharedMesh = config.data[index].wolf3DOutfitTopMesh;
        wolf3DOutfitTopSkinnedMeshRenderer.sharedMaterial = config.data[index].wolf3DOutfitTopMaterial;

        wolf3DOutfitTeethSkinnedMeshRenderer.sharedMesh = config.data[index].wolf3DOutfitTeethMesh;
        wolf3DOutfitTeethSkinnedMeshRenderer.sharedMaterial = config.data[index].wolf3DOutfitTeethMaterial;



    }
}
