using LibNoise.Generator;

namespace TerrainGenerator
{
    public class NoiseProvider : INoiseProvider
    {
        private Perlin PerlinNoiseGenerator;

        public NoiseProvider()
        {
            // http://libnoise.sourceforge.net/tutorials/tutorial4.html
            PerlinNoiseGenerator = new Perlin();
        }
        
        public float GetValue(float x, float z)
        {
            return (float)(PerlinNoiseGenerator.GetValue(x, 0, z) / 2f) + 0.5f;
        }
    }
}