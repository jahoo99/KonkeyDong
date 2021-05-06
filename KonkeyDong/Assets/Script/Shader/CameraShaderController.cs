using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(Camera))]
public class CameraShaderController : MonoBehaviour
{


    [SerializeField]  private Shader outlineShader;
    [SerializeField] private Shader neonShader;
    [SerializeField] private Shader bloomShader;
    [SerializeField] private Shader gbShader;

    public List<SnapshotFilter> filters = new List<SnapshotFilter>();
    private int filterIndex = 0;
    private void Awake()
    {



        filters.Add(new PixelFilter("Game Boy", new Color(0.61f, 0.73f, 0.06f),gbShader));
        filters.Add(new NeonFilter("Neon", Color.cyan, bloomShader,new BaseFilter("", Color.white, neonShader)));
        filters.Add(new BaseFilter("Outlines", Color.white, outlineShader));
    }

    private void OnRenderImage(RenderTexture src, RenderTexture dst)
    {
        filters[filterIndex].OnRenderImage(src, dst);
    }

  
}
