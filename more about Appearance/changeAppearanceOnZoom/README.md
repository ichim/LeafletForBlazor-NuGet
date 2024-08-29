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
