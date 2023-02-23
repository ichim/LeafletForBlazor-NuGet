## Polygons and symbolization by attributes

LeafletForBlazor uses a _customized Leaflet format_ that allows the definition of symbolization rules.

The data used in the code can be found in the file "./polygons_and_symbology.json"

In reality, NuGet uses the format from the [leaflet documentation](https://www.rfc-editor.org/rfc/rfc7946) to which a new JSON "symbology" element has been added.

The new format is:

	{
		"data": ...,
		"symbology": ...
	}
	

![PolygonsSymbolization](https://user-images.githubusercontent.com/8348463/221033035-2f11654e-010c-4c64-b1c9-ae9cbe4737bf.png)
