# 🧾 MapPopup component and OnClick event

You can use the MapPopup component to display data for a StreamPoint you have clicked on.

MapPopup hosting:

        <Map>
            <MapPopup @ref="mapPopup">
                <HeaderContent>
                        <h6 style="margin-top:0px;margin-bottom:0px;">Attributes</h6>
                </HeaderContent>
                <PopupContent>
                    @{
                        @if (points.Count != 0)
                        {
                            <div class="d-flex flex-wrap gap-3">
                                @foreach (var point in points)
                                {
                                    <label style="font-weight:800;color:darkblue">@point.type</label>
                                }
                            </div>
                        }
                </PopupContent>
            </MapPopup>
        </Map>


Blazor page:

        @code {
            List<StreamPoint> points = new List<StreamPoint>();
            private MapPopup? mapPopup;
            }

OnClick event:

        if (map?.Geometric?.Points != null)
        {
            map.Geometric.Points.OnClick += (sender, args) =>
            {
                points = args.points;
                mapPopup?.Show(args, 200, 200);
            };
        }
