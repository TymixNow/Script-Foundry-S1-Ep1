using UnityEngine;
using UnityEditor;

public class importPixelArt : AssetPostprocessor
{
	void OnPreprocessTexture()
	{
		TextureImporter textureImporter = (TextureImporter)assetImporter;
		textureImporter.spritePixelsPerUnit = 16;
		textureImporter.textureCompression = TextureImporterCompression.Uncompressed;
		textureImporter.filterMode = FilterMode.Point;
	}
}