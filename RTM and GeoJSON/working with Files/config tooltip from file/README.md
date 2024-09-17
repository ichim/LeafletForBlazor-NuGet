# Configuring custom tooltip

    "tooltip": {
       "content": "BB<br/><b>${name}</b><br/><i><font size='4' face='verdana' color='blue' >${description}</font></i><br/><img width='100%' height='100%' src = '${url}'></img>",
       "opacity": 0.8,
       "visibilityZoomLevels": {
         "minZoomLevel": 15,
         "maxZoomLevel": 16
       }

where: name and description are properties of GeoJSON items

## GeoJSON item

The data structure of a GeoJSON element is as follows:


    {
          "type": "Feature",
          "geometry": {
            "type": "Point",
            "coordinates": [ 44.44695351120105, 26.096702416100246 ]
          },
          "properties": {
            "name": "Piata Romana",
            "description": "historical place",
            "url": "https://blog.travelminit.ro/wp-content/uploads/2016/01/Bucurestiul-noaptea.jpg"
          }
    }
