# Measure line

Add line with addMeasure() method:

            await realTimeMap.Geometric.DisplayPolylinesFromArray.addMeasure(
                                                                new RealTimeMap.MeasureLine()
                                                                {
                                                                    start = new double[2] { 43.971312524467095, 25.328505256329578},    //start point of measure line
                                                                    end = new double[2] { 43.970933062429864, 25.329087513345627},      //end point of measure line
                                                                    text = "20 meters", //obsolete and replaced with content
								    content = "20 meters", //replaces text
                                                                    textAnchor = new double[2] {- 2, 8 }, //obsolete and replaced with labelAnchor
								    labelAnchor = new double[2] {- 2, 8 }, //replaces textAnchor
                                                                    labelStyle = "min-width:40px;height:100%;background-color:#084886;border-radius:6px;color:#d2efff;text-align:center;font-size:10px;"

                                                            });



Delete all measure lines with deleteMeasure() method:

			await realTimeMap.Geometric.DisplayPolylinesFromArray.deleteMeasure();
