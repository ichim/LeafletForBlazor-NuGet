# Simplify Appearance (Point Symbols) based on Zoom Level

When the map display scales have small values, the observer is far from the map, the point symbols can no longer be icons.

For example, at zoom levels between 18 and 16 the points can be displayed with icons:

![image](https://github.com/user-attachments/assets/981b0de4-2ec2-48c4-99ff-f99c66b1a2a9)

For smaller scales, when we move away from the map, the symbols can no longer be very detailed. At small scales, the points should be shown with circle markers:

![image](https://github.com/user-attachments/assets/2537e318-c47f-4b4b-8a1a-714fa041645e)

In order to simplify the display symbols in the map, the OnZoomLevelEndChange event will be used:

      <RealTimeMap height="calc(100vh - 10rem)" width="calc(100vw - 18rem)" OnZoomLevelEndChange="onZoomLevelEnd"></RealTimeMap>

where:

     private void onZoomLevelEnd(RealTimeMap.MapZoomEventArgs args)
     {
         zoomLevel = args.zoomLevel;
    
         if(args.zoomLevel <=15 && notChanged)
         {
             simplifyAppearance(args.sender);
             notChanged = false;
         }
         if(args.zoomLevel>15 && !notChanged)
         {
             defaultAppearance(args.sender);
             notChanged = true;
         }
         StateHasChanged();
     }

## Default Appearance

The default display of the points will be done with the defaultAppearance() method and will use icons for display:

        private void defaultAppearance(RealTimeMap rtm)
        {
            System.Diagnostics.Debug.WriteLine("Icons Appearance");
            rtm.Geometric.Points.AppearanceOnType((item) => item.type == "ambulance").pattern = new RealTimeMap.PointIcon()
                {
                    iconUrl = "https://localhost:7140/icons/ambulance.png",
                    iconSize = new int[2] { 80, 50 },
                    iconAnchor = new int[2] { 40, 25 },
                };
            rtm.Geometric.Points.AppearanceOnType((item) => item.type == "police crew" || item.type == "intervention crew").pattern = new RealTimeMap.PointIcon()
                {
                    iconUrl = "https://localhost:7140/icons/police.png",
                    iconSize = new int[2]{64,64},
                    iconAnchor = new int[2]{32,32},
                };
            rtm.Geometric.Points.AppearanceOnType((item) => item.type == "suspicious vehicle").pattern = new RealTimeMap.PointIcon()
                {
                    iconUrl = "https://localhost:7140/icons/suspicious.png",
                    iconSize = new int[2] { 48, 48 },
                    iconAnchor = new int[2] { 24, 24 },
                };
        }

## Simplify Appearance

Simplification is done with the simplifyAppearance() method:

         private void simplifyAppearance(RealTimeMap rtm)
         {
             System.Diagnostics.Debug.WriteLine("Simplify Appearance");
             rtm.Geometric.Points.AppearanceOnType((item) =>
                                                             item.type == "police crew" ||
                                                             item.type == "intervention crew" ||
                                                             item.type == "ambulance"
                                                             ).pattern = new RealTimeMap.PointSymbol()
                                                                 {
                                                                     radius = 6,
                                                                     color = "gray",
                                                                     opacity = 1,
                                                                     fillColor = "blue",
                                                                     fillOpacity = 0.5,
                                                                     weight = 2
                                                                 };
      
             rtm.Geometric.Points.AppearanceOnType((item) =>
                                                             item.type == "suspicious vehicle"
                                                             ).pattern = new RealTimeMap.PointSymbol()
                                                                 {
                                                                     radius = 6,
                                                                     color = "gray",
                                                                     opacity = 1,
                                                                     fillColor = "red",
                                                                     fillOpacity = 0.5,
                                                                     weight = 2
                                                                 };
         }
