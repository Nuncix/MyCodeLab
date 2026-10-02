import { Injectable } from '@angular/core';
import { Observable, interval, map, of } from 'rxjs';

@Injectable({
    providedIn: 'root',
})
export class RealTimeDataService {
    _x: number[] = [];
    _y: number[] = [];
    _iter = 0;
    data$: Observable<{ x: number[]; y: number[] } | null> = of(null);

    constructor() {}

    connect() {
        // Connect to a websocket that regularly pushes data.
        // Reformat to x/y data to plot.
        this.data$ = interval(500).pipe(
            map(() => {
                // We will show the 20 most recent values
                this._x.push(this._iter);
                this._iter = this._iter + 1;

                this._y.push(Math.random() + 3); // Random data
                if (this._y.length > 20) {
                    this._x = this._x.slice(1, -1);
                    this._y = this._y.slice(1, -1);
                }
                return {
                    x: this._x,
                    y: this._y,
                };
            })
        );

        return this.data$;
    }
}
