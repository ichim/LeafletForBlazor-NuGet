# LeafletForBlazor-NuGet
 Using LeafletForBlazor NuGet Package

## What's new?

 - Map tooltips scaling. Configured using improved format:

       "tooltip":{

       ...
   
       "scaling": {
       
          "start_with": 16,

          "stop_with": 18
        
          }
          
       }

 - Map GeoJSON layer scaling. Configured using improved format:

       "symbology":{

        ...

            "scaling": {

             "start_with": 16,

             "stop_with": 18

             }

            }

![scaling01](https://user-images.githubusercontent.com/8348463/221374917-8a662947-6ae7-4ddb-9cf7-7ae79329c72b.gif)


New Load Map boolean parmeter (anyway_overlay_layers_control), which forces the display of GeoJSON layers in the Layers Control.


     Map.LoadParameters parameters = new Map.LoadParameters()
     {
            anyway_overlay_layers_control = true
     }

The names of the files will be displayed in the Layers Control, the overlay layers section.
