# Terrain Generator Script  
## Setup  
Use the following the help set up the `GenerateMapFromHeightmap` script.  
### Heightmap  
First, ensure that the heightmap you want to use is checked read/write.  This allow Unity to read and set pixels of the input heightmap. Click on the image in the inspector and open the advanced tab.  Make sure Read/ Write Enabled is checked. 
![](https://imgur.com/7DmAb2I.png)
### Script    
For the script to work, you need to assign a `material` and `heightmap`.  All other values have default values.  `mapSize` is in meters.  The mesh height can be set independently, but should be about 10% of the `mapSize`.  

Currently, noise properties does not effect the heightmap terrain.
![](https://imgur.com/4qteJ4R.png)
## Properties  
|Property|Description|
|:-|:-|
|**Heightmap Properties**||
|*matieral*| The material that will be instanced on each terrain chunk.|
|*heightmap*| The heightmap the terrain will be generated from.|
|*mapSize*| The size of the generated map in meters.|
|**Noise Properties**| Inactive.  Used for endless terrain generation|
|*noiseScale*| The size of the noise map generated for the terrain.|
|*octaves*| The number of iterations the noise algorithm will make during generation.|
|*persistence*| A multiplier that determines how quickly the amplitudes diminish for each successive octave in a Perlin-noise function.|
|*lacunarity*| A multiplier that determines how quickly the frequency increases for each successive octave in a Perlin-noise function.|
|*seed*| Used to generate the same noise map.|
|*offset*| The offset of the current chunk of noise from the origin.|
|**Mesh Properties**||
|*meshHeight*| The absolute maximum height of the mesh.|
|*meshHeightCurve*| An animation curve used to dampen the height of the mesh.|
|*EditorPreviewLOD*| THe current LOD of the chunks.|
|*NormalizeMode*| How the edges of the chunks are normalized.|
|**Color Properties**|Inactive|
|**Regions**|Inactive|
