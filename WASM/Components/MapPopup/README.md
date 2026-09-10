# MapPopup

Contextual display driven by data source.


                  <Map
                       height="calc(100vh - 1rem)"
                       width="calc(100vw - 2rem)"
                      <MapPopup @ref="mapPopup">
                          <HeaderContent>
                                  <h3>Attributes</h3>
                  
                          </HeaderContent>
                          <PopupContent>
                              @{
                                 //Content of popup
                              }
                          </PopupContent>
                      </MapPopup>
                  </Map>
