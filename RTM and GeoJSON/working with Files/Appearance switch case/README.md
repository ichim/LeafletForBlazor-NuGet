# Appearance based on switch/cases

You can create distinct _symbolization classes_ based on the properties of GeoJSON file items.
How appearance can be customized by defining distinct classes?

It can be done using a JSON switch object of *appearance* item:

    {
        switch: {
          "fieldName": "name",  //field name of item properties 
          "cases": []           //value: {}
          "default": {}         //symbol
    }

What is the structure of a _cases_ array item?

    "<property value>": {
                        "color": "green",
                        "opacity": 0.6,
                        "weight": 8
                      }

#### Example code

        {
          "name": "Streets",
          "data": [
            {
              "type": "Feature",
              "geometry": {
                "type": "Polyline",
                "coordinates": [
                  [
                    [ 44.44586931032441, 26.097146294088674 ],
                    [ 44.44567571771458, 26.096377445586192 ],
                    [ 44.44557322665131, 26.096160510467932 ],
                    [ 44.44542518267126, 26.09578087503316 ]
                  ]
                ]
              },
              "properties": {
                "name": "Biserica Amzei"
              }
            }
          ],
          "appearance": {
            "switch": {
              "fieldName": "name",
              "cases": [
                {
                  "Biserica Amzei": {
                    "color": "green",
                    "opacity": 0.6,
                    "weight": 8
                  }
                }
              ],
              "default": {
                "color": "gray",
                "opacity": 0.6,
                "weight": 8
              }
            }
          }
        }
