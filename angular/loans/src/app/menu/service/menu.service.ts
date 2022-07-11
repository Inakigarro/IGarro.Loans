import { Injectable } from "@angular/core";
import { Action, Store } from "@ngrx/store";
import * as MenuSelectors from '../state/menu.selectors';

@Injectable({
    providedIn: 'root'
})
export class MenuService {
    constructor(private readonly store: Store){}

    public getExpanded$ = this.store.select(
        MenuSelectors.selectExpanded
    );
    
    public dispatch(action: Action){
        this.store.dispatch(action);
    }
}