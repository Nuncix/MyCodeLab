import { AfterViewInit, Component, ViewChild } from '@angular/core';
import { PlotlyComponent } from 'angular-plotly.js';
import { Plotly } from 'angular-plotly.js/lib/plotly.interface';
import { RealTimeDataService } from '../real-time-data.service';

@Component({
    selector: 'app-plotly',
    templateUrl: './plotly.component.html',
    styleUrls: ['./plotly.component.scss'],
})
export class PlotlyChartComponent implements AfterViewInit {
    @ViewChild(PlotlyComponent) plotlyComponent?: PlotlyComponent;

    public DEFAULT_LAYOUT: Partial<Plotly.Layout> = {
        // margin: {
        //     b: 56,
        //     l: 60,
        //     t: 40,
        // },
        // xaxis: {
        //     spikethickness: 1,
        // },
        yaxis: {
            // title: undefined,
            // side: 'left',
            range: [0, 5],
            // position: 0,
            // autorange: true,
            // fixedrange: false,
            // spikethickness: 1,
            // showline: true,
            // rangemode: 'normal',
            // ticklen: 3,
            // linecolor: '#cacaca',
            // tickcolor: '#cacaca',
        },
        // showlegend: false,
        // hovermode: 'x',
        title: 'Some Data to Highlight',
    };

    // Line chart
    public data = [{ x: [0], y: [0], type: 'scatter' }];

    constructor(private realTimeDataService: RealTimeDataService) {}

    ngAfterViewInit(): void {
        this.realTimeDataService.connect().subscribe((values) => {
            console.log(values);
            if (values) {
                // this.data[0].x.push(...[values.x ?? 0]);
                // this.data[0].y.push(...[values.y ?? 0]);
                this.data = [
                    {
                        x: values.x ?? [0],
                        y: values.y ?? [0],
                        type: 'scatter',
                    },
                ];
            }
        });
    }
}
