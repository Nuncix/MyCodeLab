import { CommonModule } from '@angular/common';
import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppComponent } from './app.component';
import { PlotlyChartComponent } from './plotly/plotly.component';

import { PlotlyModule } from 'angular-plotly.js';
import * as Plotly from 'plotly.js-dist-min';

PlotlyModule.plotlyjs = Plotly;

@NgModule({
    declarations: [AppComponent, PlotlyChartComponent],
    imports: [CommonModule, BrowserModule, PlotlyModule],
    providers: [],
    bootstrap: [AppComponent],
})
export class AppModule {}
