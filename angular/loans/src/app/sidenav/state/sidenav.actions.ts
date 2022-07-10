import { createAction, props } from "@ngrx/store";

export const initSidenav = createAction(
    '[Sidenav] - Sidenav initialized'
);

export const expandSidenav = createAction(
    '[Sidenav] - Sidenav expanded',
    props<{ expanded: boolean}>()
);

export const hideSidenav = createAction(
    '[Sidenav] - Sidenav hided',
    props<{ expanded: boolean}>()
);