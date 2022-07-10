import { Injectable } from "@angular/core";
import { Action, Store } from "@ngrx/store";

@Injectable({
    providedIn: 'root'
})
export class AppService {
    constructor(private readonly store: Store){}

    public dispatch(action: Action){
        this.store.dispatch(action);
    }
}