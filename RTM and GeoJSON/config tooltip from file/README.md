# Configuring custom tooltip

    "tooltip": {
       "content": "BB<br/><b>${name}</b><br/><i><font size='4' face='verdana' color='blue' >${description}</font></i><br/><img width='100%' height='100%' src = '${url}'></img>",
       "opacity": 0.8,
       "visibilityZoomLevels": {
         "minZoomLevel": 15,
         "maxZoomLevel": 16
       }

where: name and description are properties of GeoJSON items
