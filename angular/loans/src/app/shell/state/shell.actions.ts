import { createAction } from "@ngrx/store";

export const initShell = createAction(
    '[Shell] - Shell initialized'
);

// Sidenav menu.
export const menuButtonClicked = createAction(
    '[Top bar Menu Button] - Menu Button clicked'
);

// Profile menu.
export const profilePictureButton = createAction(
    '[Profile Picture Button] - Profile picture button clicked'
);

export const profileButtonClicked = createAction(
    '[Profile Button] - Profile button clicked'
);