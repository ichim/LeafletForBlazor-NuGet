# 👁️ View


Setting the current view center and zoom level:

            map.View.SetCenter(40.0, 20.0);
            map.View.SetZoomLevel(8);

Getting the current view center and zoom level:

            var zoom = await map.View.getZoomLevelAsync();
            var center = await map.View.getCenterAsync();
