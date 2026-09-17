# 🧾 MapPopup component and OnClick event

You can use the MapPopup component to display data for a StreamPoint you have clicked on.


OnClick event:

        if (map?.Geometric?.Points != null)
        {
            map.Geometric.Points.OnClick += (sender, args) =>
            {
                points = args.points;
                mapPopup?.Show(args, 200, 200);
            };
        }
