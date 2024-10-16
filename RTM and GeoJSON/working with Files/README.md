# Upload data from GeoJSON files

You can load spatial data stored in files in GeoJSOM format. The data may be in accordance with the specifications [GeoJSON specification (RFC 7946)](https://www.rfc-editor.org/rfc/rfc7946) or may have settings regarding the configuration of the appearance, tooltips or scales at which the data are visible on the map

## **DataFromGeoJSON** class

It is a class hosted by the **Geometric** class. This class allows adding spatial data from **GeoJSON** formats.

Two formats are used, both complying with [GeoJSON specification (RFC 7946)](https://www.rfc-editor.org/rfc/rfc7946):

1. The first format is an array that exactly respects the format [GeoJSON specification (RFC 7946)](https://www.rfc-editor.org/rfc/rfc7946)

		<RealTimeMap OnAfterMapLoaded="@OnAfterMapLoaded" width="460px" height="462px" />
		@code{
			public async Task OnAfterMapLoaded(RealTimeMap.MapEventArgs args)
			 {
				await args.sender.Geometric.DataFromGeoJSON.addFromFiles(urlsArray);
			 }
		}

1. And another JSON format, which for the "data" property we have the same array [GeoJSON specification (RFC 7946)](https://www.rfc-editor.org/rfc/rfc7946). In addition, this format accepts customization of appearance, tooltips, visibility etc 



		<RealTimeMap OnAfterMapLoaded="@OnAfterMapLoaded" width="460px" height="462px" />
		@code{
			public async Task OnAfterMapLoaded(RealTimeMap.MapEventArgs args)
			 {
				await args.sender.Geometric.DataFromGeoJSON.addFromFiles(urlsArray);
			 }
		}
**DataFromGeoJSON** addFromFiles(string[]) method accepts an array of url addresses of GeoJSON files.

example code:

 - Blazor page:


		<RealTimeMap OnAfterMapLoaded="@onAfterMapLoad" width="460px" height="462px" />


 - code block:

 		string path = "http://localhost:5292/";
		private void onAfterMapLoad(RealTimeMap.MapEventArgs args)
		{
		    var realTimeMap = args.sender as RealTimeMap;
		    realTimeMap.Geometric.DataFromGeoJSON.addFromFiles(new string[3]
		    {
		        $"{path}/geojson/points.json",
		        $"{path}/geojson/polylines.json",
		        $"{path}/geojson/polygons.json"
		    });
		}

## Configuring shapes appearance

The configuration can be done in the GeoJSON file and can be: 
- simple [example simple appearance](https://github.com/ichim/LeafletForBlazor-NuGet/tree/main/RTM%20and%20GeoJSON/working%20with%20Files/GeoJSON%20from%20file)
- switch/cases [example switch/cases appearance](https://github.com/ichim/LeafletForBlazor-NuGet/tree/main/RTM%20and%20GeoJSON/working%20with%20Files/Appearance%20switch%20case)
- shapes scales visibility [example scale visibility](https://github.com/ichim/LeafletForBlazor-NuGet/tree/main/RTM%20and%20GeoJSON/working%20with%20Files/Appearance%20switch%20and%20visibility) 

## Configuring custom tooltips

You can configure the content of tooltips messages in GeoJSON files [configuring tooltips example](https://github.com/ichim/LeafletForBlazor-NuGet/tree/main/RTM%20and%20GeoJSON/working%20with%20Files/config%20tooltip%20from%20file)


