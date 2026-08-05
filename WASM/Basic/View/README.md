# 👁️ View


            map.View.SetCenter(40.0, 20.0);
            map.View.SetZoomLevel(8);
            var zoom = await map.View.getZoomLevelAsync();
            var center = await map.View.getCenterAsync();
