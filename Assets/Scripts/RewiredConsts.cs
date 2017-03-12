/* Rewired Constants
   This list was generated on 03/12/2017 01:25:58
   The list applies to only the Rewired Input Manager from which it was generated.
   If you use a different Rewired Input Manager, you will have to generate a new list.
   If you make changes to the exported items in the Rewired Input Manager, you will need to regenerate this list.
*/

namespace RewiredConsts {
    public static class Action {
        // Default
        [Rewired.Dev.ActionIdFieldInfo(categoryName = "Default", friendlyName = "Horizontal")]
        public const int Horizontal = 2;
        [Rewired.Dev.ActionIdFieldInfo(categoryName = "Default", friendlyName = "Vertical")]
        public const int Vertical = 3;
        [Rewired.Dev.ActionIdFieldInfo(categoryName = "Default", friendlyName = "Move")]
        public const int Move = 5;
        [Rewired.Dev.ActionIdFieldInfo(categoryName = "Default", friendlyName = "Restart")]
        public const int Restart = 6;
        [Rewired.Dev.ActionIdFieldInfo(categoryName = "Default", friendlyName = "Exit")]
        public const int Exit = 7;
    }
    public static class Category {
        public const int Default = 0;
    }
    public static class Layout {
        public static class Joystick {
            public const int Default = 0;
        }
        public static class Keyboard {
            public const int Default = 0;
        }
        public static class Mouse {
            public const int Default = 0;
        }
        public static class CustomController {
            public const int Default = 0;
        }
    }
}
