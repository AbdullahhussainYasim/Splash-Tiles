Shader "Unlit/GradientBackground"
{
    Properties
    {
        _TopColor ("Top Color", Color) = (1, 1, 1, 1)
        _BottomColor ("Bottom Color", Color) = (0, 0, 0, 1)
    }
    SubShader
    {
        Tags { "RenderType"="Opaque" }
        LOD 100

        Pass
        {
            CGPROGRAM
            #pragma vertex vert
            #pragma fragment frag

            struct appdata_t { float4 vertex : POSITION; };
            struct v2f
            {
                float4 pos : SV_POSITION;
                float2 uv : TEXCOORD0;
            };

            float4 _TopColor;
            float4 _BottomColor;

            v2f vert (appdata_t v)
            {
                v2f o;
                o.pos = UnityObjectToClipPos(v.vertex);
                o.uv = v.vertex.xy;
                return o;
            }

            float4 frag (v2f i) : SV_Target
            {
                float t = i.uv.y; // Interpolate vertically
                return lerp(_BottomColor, _TopColor, t);
            }
            ENDCG
        }
    }
}
