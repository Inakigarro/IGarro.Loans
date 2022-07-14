import { createAction, props } from "@ngrx/store";

export const initSidenav = createAction(
    '[Sidenav] - Sidenav initialized'
);

// Menu sidenav
export const expandSidenav = createAction(
    '[Sidenav] - Sidenav expanded',
    props<{ expanded: boolean}>()
);

export const hideSidenav = createAction(
    '[Sidenav] - Sidenav hided',
    props<{ expanded: boolean}>()
);

// Profile sidenav
export const expandProfile = createAction(
    '[Profile sidenav] - Profile sidenav expanded',
    props<{ expanded: boolean}>()
);

export const hideProfile = createAction(
    '[Profile sidenav] - Profile sidenav hided',
    props<{ expanded: boolean}>()
)

export const backdropClicked = createAction(
    '[Sidenav Content] - Backdrop clicked'
)