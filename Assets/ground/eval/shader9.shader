Shader "Custom/shader9"
{
    Properties
    {
        _MainTex ("Albedo (RGB)", 2D) = "white" {}
    }
    SubShader
    {
        Tags { "RenderType"="Opaque" }

        cull back

        CGPROGRAM
        #pragma surface surf Toon


        sampler2D _MainTex;

        struct Input
        {
            float2 uv_MainTex;
        };

        void surf (Input IN, inout SurfaceOutput o)
        {
            fixed4 c = tex2D (_MainTex, IN.uv_MainTex);
            o.Albedo = c.rgb;
            o.Alpha = c.a;
        }

        float4 LightingToon(SurfaceOutput s, float3 lightDir, float atten) {
            float result = dot(s.Normal, lightDir) * 0.5 + 0.5;
            
            if (result > 0.7) {
                result = 0.9;
            }
            else {
                result = 0.4;
            }

            return result;
        }

        ENDCG
    }
    FallBack "Diffuse"
}
