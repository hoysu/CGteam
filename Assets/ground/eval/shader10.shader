Shader "Custom/shader10"
{
    Properties
    {
        _MainTex ("Albedo (RGB)", 2D) = "white" {}
    }
    SubShader
    {
        Tags { "RenderType"="Opaque" }

        cull front 

        CGPROGRAM
        #pragma surface surf NoLight noambient vertex:vert 

        sampler2D _MainTex;

        struct Input
        {
            float2 uv_MainTex;
        };

        void surf (Input IN, inout SurfaceOutput o)
        {
            fixed4 c = tex2D (_MainTex, IN.uv_MainTex) ;
            o.Albedo = c.rgb;
            o.Alpha = c.a;
        }

        void vert(inout appdata_full v) {
            v.vertex.xyz += v.normal.xyz * 0.01;
        }

        float4 LightingNoLight(SurfaceOutput s, float3 lightDr, float atten) {
            return float4(0, 0, 0, 1);
        }



        ENDCG



        cull back

        CGPROGRAM
        #pragma surface surf Toon

        sampler2D _MainTex;

        struct Input
        {
            float2 uv_MainTex;
        };

        void surf(Input IN, inout SurfaceOutput o)
        {
            fixed4 c = tex2D(_MainTex, IN.uv_MainTex);
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
