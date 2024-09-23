### Improved Leaflet Format. This format allows configuring the symbolization of map elements

_Is an leaflet format in which symbolization (with scaling) and tooltip configuration (with scaling) has been added_ to the leaflet data [(RFC 7946)](https://www.rfc-editor.org/rfc/rfc7946).

### Advantages ###
	
- The symbology and tooltips configuration are stored along with the data;
- Changing the symbolization will be done without changing the code;
- Also, changing tooltips configuration will be done without changing the code;
- Several applications (web, mobile, etc.) will display the same map, the same symbols;

			{
				  "data": [...GeoJSON specification (RFC 7946)...],
				  "symbology": { ... },
				  "tooltip": { ... }
			}
			

Meaning of JSON (improved format) parameters:

 - JSON _"data"_ paratemeter expects an array of GeoJSON items [GeoJSON specification (RFC 7946)](https://www.rfc-editor.org/rfc/rfc7946)
 - JSON _"symbology"_ parameter expects the custom symbology of GeoJSON items

	   "symbology": {
			"default": {
			"color": "red",
			"weight": 5,
			"opacity": 0.4
			},
			"case": {
				"field_name": "name",
				"classes": [
						{
						"value": "Bdul Magheru",
						"symbol": {
							"color": "yellow",
							"weight": 5,
							"opacity": 0.4
							}
						},
						{
					  "value": "Bdul Dacia",
					  "symbol": {
							"color": "green",
							"weight": 5,
							"opacity": 0.4
						}
					}
				]
			}
			"scaling": {
				"start_with": 16,
				"stop_with": 18
				}
		}

In the previous example, we have a default symbol and two other symbols for two predefined classes. This two classes are defined based on the values in the "name" field.

Result of polygons classes symbolization of [GitHub example](https://github.com/ichim/LeafletForBlazor-NuGet/tree/main/PolygonsSymbolization):

Symbolization by classes is done based on a property (field) of the GeoJSON elements.

for example:
- commercial areas were symbolized in yellow;
- residential areas were symbolized in green;
- other areas were symbolized in red;

![PolygonsSymbolization](https://user-images.githubusercontent.com/8348463/221033035-2f11654e-010c-4c64-b1c9-ae9cbe4737bf.png)

[Working with JSON file - GitHub example code](https://github.com/ichim/LeafletForBlazor-NuGet/tree/main/Basemap%20Layers%20Control)
