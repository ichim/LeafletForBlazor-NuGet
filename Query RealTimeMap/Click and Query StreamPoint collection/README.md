# Query StreamPoint collection


      <RealTimeMap height="calc(100vh - 6rem)" width="calc(100vw - 18rem)" OnClickMap="onClickingMap" ></RealTimeMap>
      
      @code {
          public void onClickingMap(RealTimeMap.ClicksMapArgs value)
          {
              List<RealTimeMap.StreamPoint> findedPoints = new List<RealTimeMap.StreamPoint>();
              findedPoints = (value.sender as RealTimeMap).Geometric.Points.getItems(point => (value.sender as RealTimeMap).Geometric.Computations.distance(
                  point,
                  new RealTimeMap.StreamPoint() { latitude = value.location.latitude, longitude = value.location.longitude },
                  RealTimeMap.UnitOfMeasure.meters
                  ) <= 10
              );
              Task.Run(async delegate
              {
                  await JsRuntime.InvokeVoidAsync("alert", $"GUID: {findedPoints.First().guid}\nType: {findedPoints.First().type}\nRegistration Number: {(findedPoints.First().value as Attributes).registrationNumber}"); // Alert
              });
          }
      }
