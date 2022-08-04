import { createAction, props } from "@ngrx/store";

export const initShell = createAction(
    '[Shell] - Shell initialized'
);

// Sidenav menu.
export const menuButtonClicked = createAction(
    '[Top bar Menu Button] - Menu Button clicked'
);

// Sidenav
export const expandSidenav = createAction(
    '[Sidenav] - Sidenav expanded',
    props<{ expanded: boolean}>()
);

export const hideSidenav = createAction(
    '[Sidenav] - Sidenav hided',
    props<{ expanded: boolean}>()
);

export const backdropClicked = createAction(
    '[Sidenav Content] - Backdrop clicked'
);

// Profile menu.
export const profilePictureButton = createAction(
    '[Profile Picture Button] - Profile picture button clicked'
);

export const profileButtonClicked = createAction(
    '[Profile Button] - Profile button clicked'
);

export const expandProfile = createAction(
    '[Profile sidenav] - Profile sidenav expanded',
    props<{ expanded: boolean}>()
);

export const hideProfile = createAction(
    '[Profile sidenav] - Profile sidenav hided',
    props<{ expanded: boolean}>()
);